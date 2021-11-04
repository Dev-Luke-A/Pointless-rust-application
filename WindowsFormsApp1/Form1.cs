using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        KeyboardHook hook = new KeyboardHook();
        int n = 0;
        public Form1()
        {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(global::ModifierKeys.Alt,
                Keys.A);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
          
                SendKeys.Send(Constants.raw[n]);
            Thread.Sleep(1000);
            n ++; 
              
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }
        private void HandleHotkey()
        {
           
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }
      
       
    }
}
