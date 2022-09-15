using System.Data.SqlTypes;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms {
    public partial class Form1 : Form {
        private MenuStrip menuStrip1 = new MenuStrip ();
        private ToolStripMenuItem menu1 = new ToolStripMenuItem ();
        private ToolStripMenuItem fileMenuItem = new ToolStripMenuItem ();

        public Form1 () {
            InitializeComponent ();
        }

        public void FormLayout () {
            LoadForm ();
            LoadMenu ();
        }

        private void LoadForm () {
            this.Name = "Telugu Alphabet Examination";
            this.Text = "Telugu Alphabet Examination";
            this.BackColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size (500, 500);
            this.ControlBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog ;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
        }

        private void LoadMenu () {
            // menuStrip1
            this.menuStrip1.Items.AddRange (new ToolStripItem[] {
                menu1
            });
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Location = new System.Drawing.Point (0, 0);
            this.menuStrip1.Size = new System.Drawing.Size (800, 24);
            this.menuStrip1.Name = "menuStrip1";

            // Menu1
            this.menu1.Image = System.Drawing.Image.FromFile ("images/menuHamburger.png");
            this.menu1.Size = new System.Drawing.Size (180, 20);
            this.menu1.Name = "menu1";
            this.menu1.AutoSize = false;
            this.menu1.DropDownItems.AddRange (new ToolStripItem[] {
                this.fileMenuItem
            });

            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.AutoSize = false;
            this.fileMenuItem.Size = new System.Drawing.Size (180, 20);
            this.fileMenuItem.Text = "Exit";
            this.fileMenuItem.Click += new System.EventHandler (this.Mouse_Click);
            this.Controls.Add (this.menuStrip1);
        }

        void Mouse_Click (object sender, EventArgs e) {
            Application.Exit ();
        }
    }
}