using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace AssaultCubeCheats{
    public partial class AssaultCubeCheatForm : Form {
        private Process[] processes = null;         // Obiekt process, który jest potrzebny do sprawdzenia;
                                                        // czy proces jest uruchomiony;

        private IntPtr processBaseAdress = IntPtr.Zero;                 // Statyczny wskaznik procesy;
        private IntPtr playerBaseAddress = IntPtr.Zero;                 // Statyczny wskaznik Gracza;

        // Wartości, które się zmienią po wybraniu odpowiednich opcji w gui;
        private bool unlimitedHealth = false;
        private bool unlimitedArmour = false;
        private bool infiniteGranades = false;
        private bool infiniteAmmo = false;
        
        // Cheat włączony lub wyłączony
        private bool enabled = true;

        private int value = 0x3E7; // Wartość, którą  będziemy wpisywać do pamięci, 
                                        // jest to 999 w systemie dziesiętnym;

        public AssaultCubeCheatForm() {
            InitializeComponent();
        }

        // Metoda odpowiedzialna za zamknięcie aplikacji wraz z zabiciem wątków;
        private void ApplicationExit() {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void AssaultCubeCheat_Load(object sender, EventArgs e) {

        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            ApplicationExit();
        }

        private void exit_Click(object sender, EventArgs e) {
            ApplicationExit();
        }

        // Po kliknięciu przycisku 'enable';
        private void enable_Click(object sender, EventArgs e){
            processes = Process.GetProcessesByName("ac_client");                // Pobieramy proces o nazwie 'ac_client';
            Thread thread = new Thread(cheatMain);                      // Definicja wątku, w którym będzie uruchomiona
                                                                            // główna funkcja;

            enabled = true;         // Uruchomienie cheata;


            // Jeśli długość zwróconego przez metode GetProcessesByname() nie równa się 0 - czyli proces istnieje;
            if(processes.Length != 0) {
                thread.Start();             // Uruchomienie nowego wątku;

                statusValue.Text = "enabled";       // Zmiana tekstu na 'enabled';
                statusValue.ForeColor = System.Drawing.Color.Green;         // Zmiana koloru tekstu na zielony;
            } else {  // W przeciwnym wypadku
                statusValue.Text = "process not found";  // Zmien tekst;
                statusValue.ForeColor = System.Drawing.Color.DarkRed; // Zmien kolor;

                enabled = false; // Wyłącz cheata;
            }
            
        }

        // Po kliknięciu przycisku disable;
        private void disable_Click(object sender, EventArgs e){
            if(processes.Length != 0) {
                enabled = false;
                statusValue.Text = "disabled";
                statusValue.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void health_CheckedChanged(object sender, EventArgs e){
            if(health.Checked){
                unlimitedHealth = true;
            } else{
                unlimitedHealth = false;
            }
        }

        private void armour_CheckedChanged(object sender, EventArgs e) {
            if(armour.Checked) {
                unlimitedArmour = true;
            } else {
                unlimitedArmour = false;
            }
        }

        private void granades_CheckedChanged(object sender, EventArgs e) {
            if(granades.Checked) {
                infiniteGranades = true;
            } else {
                infiniteGranades = false;
            }
        }

        private void ammo_CheckedChanged(object sender, EventArgs e) {
            if(ammo.Checked) {
                infiniteAmmo = true;
            } else {
                infiniteAmmo = false;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/sectasy0");
        }

        private void cheatMain() {
            VAMemory memory;             // Deklaracja obiektu, który będzie nam potrzebny do edycji pamięci;

            var offsets = new {                             // Anonimowa klasa z offsetami, które pobralismy z 
                health = 0xF8,                                    // Cheat engine. Można je sprawdzić klikając na odpowiedni wskaznik
                armour = 0xFC,

                granades = 0x158,

                AssaultRifleAmmo1 = 0x150,
                SniperRifleAmmo1 = 0x14C,
                PistolAmmo1 = 0x13C,

                AssaultRifleAmmo2 = 0x128,
                SniperRifleAmmo2 = 0x124,
                PistolAmmo2 = 0x114,
            };

            Process cproc = processes[0];                           // pobranie procesu;

            foreach(ProcessModule module in cproc.Modules) {               
                if(module.ModuleName.Contains("ac_client")) {               
                    processBaseAdress = module.BaseAddress;                 // Przypisanie adresu procesu do zmiennej;
                }
            }

            memory = new VAMemory("ac_client");          

            playerBaseAddress = (IntPtr) memory.ReadInt32(processBaseAdress + 0x0010F4F4);          // Pobranie wskaznika do Entity Gracza

            while(enabled) {                        // Jeśli przycisk enable został wcześniej wciśnięty

                if(unlimitedHealth) {                   // Jeśli zaznaczono checkbox
                    memory.WriteInt32(playerBaseAddress + offsets.health, value);               // Zapisz do pamięci wartość 
                }

                if(unlimitedArmour) {
                    memory.WriteInt32(playerBaseAddress + offsets.armour, value);
                }

                if(infiniteAmmo) {
                    memory.WriteInt32(playerBaseAddress + offsets.AssaultRifleAmmo1, value);
                    memory.WriteInt32(playerBaseAddress + offsets.AssaultRifleAmmo2, value);
                    memory.WriteInt32(playerBaseAddress + offsets.SniperRifleAmmo1, value);
                    memory.WriteInt32(playerBaseAddress + offsets.SniperRifleAmmo2, value);
                    memory.WriteInt32(playerBaseAddress + offsets.PistolAmmo1, value);
                    memory.WriteInt32(playerBaseAddress + offsets.PistolAmmo2, value);
                }

                if(infiniteGranades) {
                    memory.WriteInt32(playerBaseAddress + offsets.granades, value);

                }

                Thread.Sleep(100);
            }
        }
    }
}
