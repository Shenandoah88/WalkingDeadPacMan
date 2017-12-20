using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Authors Jonathan Ostler, Marcell Romero, Shenandoah Stubbs
 * YouWin is a form that lets the player know that they won!
 * 
 */
namespace ZombieLandFinal
{
    public partial class YouWin : Form
    {
        public YouWin()
        {
            InitializeComponent();
        }

        private void YouWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
        }
    }
}
