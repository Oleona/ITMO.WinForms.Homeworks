using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;
using System.Threading;

namespace SimpleCalculator
{

    /// <summary>
    /// Summary description for CalcUI.
    /// </summary>
    public class CalcUI : System.Windows.Forms.Form

    {
        private const double unRealFirstNumber = -1;
        private double firstNumder = unRealFirstNumber;

        private System.Windows.Forms.TextBox VersionInfo;
        private System.Windows.Forms.Button KeyExit;
        private System.Windows.Forms.Button KeyDate;
        internal System.Windows.Forms.TextBox OutputDisplay;
        private System.Windows.Forms.Button KeyClear;
        private System.Windows.Forms.Button KeyMinus;
        private System.Windows.Forms.Button KeyPlus;
        private System.Windows.Forms.Button KeyEqual;
        private System.Windows.Forms.Button KeyMultiply;
        private System.Windows.Forms.Button KeyDivide;
        private System.Windows.Forms.Button KeyPoint;
        private System.Windows.Forms.Button KeySign;
        private System.Windows.Forms.Button KeyZero;
        private System.Windows.Forms.Button KeyNine;
        private System.Windows.Forms.Button KeyEight;
        private System.Windows.Forms.Button KeySeven;
        private System.Windows.Forms.Button KeySix;
        private System.Windows.Forms.Button KeyFive;
        private System.Windows.Forms.Button KeyFour;
        private System.Windows.Forms.Button KeyThree;
        private System.Windows.Forms.Button KeyTwo;
        private System.Windows.Forms.Button KeyOne;

        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Button sqrt;
        private Button exponentiation;
        private Button inverse;
        private ToolTip toolTip1;
        private ToolStripMenuItem changeViewToolStripMenuItem;
        private ToolStripMenuItem engineeringToolStripMenuItem;
        private ToolStripMenuItem usualToolStripMenuItem;
        private Button button1;
        private Button cuberoot;
        private Button button2;
        private ToolStripMenuItem parallelFlowCalculationToolStripMenuItem;
        private Button btnParallel_stream;
        private RichTextBox rtbFactorial_value;
        private RichTextBox rtbResult;
        private IContainer components;

        public CalcUI()
        {
            //
            // Required for Windows Form Designer support
            //

            InitializeComponent();

            //
            // Get version information from the Calculator Module.
            //

            VersionInfo.Text = CalcEngine.GetVersion();
            OutputDisplay.Text = "0";
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcUI));
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parallelFlowCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqrt = new System.Windows.Forms.Button();
            this.exponentiation = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cuberoot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnParallel_stream = new System.Windows.Forms.Button();
            this.rtbFactorial_value = new System.Windows.Forms.RichTextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(200, 167);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(56, 40);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(8, 213);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(40, 40);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(8, 37);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(248, 20);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(106, 167);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(40, 40);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(56, 167);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(40, 40);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(200, 259);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(56, 40);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.toolTip1.SetToolTip(this.KeyEqual, "Equal");
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(54, 213);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(40, 40);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(8, 259);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(40, 40);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(106, 213);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(40, 40);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(154, 259);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(40, 40);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.toolTip1.SetToolTip(this.KeyPlus, "Plus");
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(200, 213);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(56, 40);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(106, 259);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(40, 40);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(8, 121);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(40, 40);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(56, 259);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(40, 40);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(106, 121);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(40, 40);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Enabled = false;
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(8, 75);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(248, 26);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(154, 213);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(40, 40);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.toolTip1.SetToolTip(this.KeyMinus, "Minus");
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(56, 121);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(40, 40);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(154, 167);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(40, 40);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.toolTip1.SetToolTip(this.KeyMultiply, "Multiply");
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(8, 167);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(40, 40);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(200, 121);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(56, 40);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(154, 121);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(40, 40);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.toolTip1.SetToolTip(this.KeyDivide, "Divide");
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changeViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // changeViewToolStripMenuItem
            // 
            this.changeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engineeringToolStripMenuItem,
            this.usualToolStripMenuItem,
            this.parallelFlowCalculationToolStripMenuItem});
            this.changeViewToolStripMenuItem.Name = "changeViewToolStripMenuItem";
            this.changeViewToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.changeViewToolStripMenuItem.Text = "Change view";
            // 
            // engineeringToolStripMenuItem
            // 
            this.engineeringToolStripMenuItem.Name = "engineeringToolStripMenuItem";
            this.engineeringToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.engineeringToolStripMenuItem.Text = "Engineering";
            this.engineeringToolStripMenuItem.Click += new System.EventHandler(this.engineeringToolStripMenuItem_Click);
            // 
            // usualToolStripMenuItem
            // 
            this.usualToolStripMenuItem.Name = "usualToolStripMenuItem";
            this.usualToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.usualToolStripMenuItem.Text = "Usual";
            this.usualToolStripMenuItem.Click += new System.EventHandler(this.usualToolStripMenuItem_Click);
            // 
            // parallelFlowCalculationToolStripMenuItem
            // 
            this.parallelFlowCalculationToolStripMenuItem.Name = "parallelFlowCalculationToolStripMenuItem";
            this.parallelFlowCalculationToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.parallelFlowCalculationToolStripMenuItem.Text = "Parallel flow calculation";
            this.parallelFlowCalculationToolStripMenuItem.Click += new System.EventHandler(this.parallelFlowCalculationToolStripMenuItem_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sqrt.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.sqrt.ForeColor = System.Drawing.Color.Blue;
            this.sqrt.Location = new System.Drawing.Point(8, 323);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(80, 40);
            this.sqrt.TabIndex = 23;
            this.sqrt.Text = "SQRT";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // exponentiation
            // 
            this.exponentiation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exponentiation.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.exponentiation.ForeColor = System.Drawing.Color.Blue;
            this.exponentiation.Location = new System.Drawing.Point(93, 323);
            this.exponentiation.Name = "exponentiation";
            this.exponentiation.Size = new System.Drawing.Size(80, 40);
            this.exponentiation.TabIndex = 24;
            this.exponentiation.Text = "EXP";
            this.exponentiation.UseVisualStyleBackColor = false;
            this.exponentiation.Click += new System.EventHandler(this.exponentiation_Click);
            // 
            // inverse
            // 
            this.inverse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inverse.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.inverse.ForeColor = System.Drawing.Color.Blue;
            this.inverse.Location = new System.Drawing.Point(176, 323);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(80, 40);
            this.inverse.TabIndex = 25;
            this.inverse.Text = "1/X";
            this.inverse.UseVisualStyleBackColor = false;
            this.inverse.Click += new System.EventHandler(this.inverse_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(8, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "N!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuberoot
            // 
            this.cuberoot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuberoot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cuberoot.BackgroundImage")));
            this.cuberoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cuberoot.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.cuberoot.ForeColor = System.Drawing.Color.Blue;
            this.cuberoot.Location = new System.Drawing.Point(93, 379);
            this.cuberoot.Name = "cuberoot";
            this.cuberoot.Size = new System.Drawing.Size(80, 40);
            this.cuberoot.TabIndex = 27;
            this.cuberoot.UseVisualStyleBackColor = false;
            this.cuberoot.Click += new System.EventHandler(this.cuberoot_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(176, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 40);
            this.button2.TabIndex = 28;
            this.button2.Text = "quadratic";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnParallel_stream
            // 
            this.btnParallel_stream.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnParallel_stream.ForeColor = System.Drawing.Color.Blue;
            this.btnParallel_stream.Location = new System.Drawing.Point(93, 433);
            this.btnParallel_stream.Name = "btnParallel_stream";
            this.btnParallel_stream.Size = new System.Drawing.Size(77, 40);
            this.btnParallel_stream.TabIndex = 29;
            this.btnParallel_stream.TabStop = false;
            this.btnParallel_stream.Text = "! =";
            this.btnParallel_stream.Click += new System.EventHandler(this.btnParallel_stream_Click);
            // 
            // rtbFactorial_value
            // 
            this.rtbFactorial_value.Location = new System.Drawing.Point(8, 433);
            this.rtbFactorial_value.Name = "rtbFactorial_value";
            this.rtbFactorial_value.Size = new System.Drawing.Size(79, 40);
            this.rtbFactorial_value.TabIndex = 30;
            this.rtbFactorial_value.Text = "";
            this.rtbFactorial_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbFactorial_value_KeyPress);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(176, 434);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(77, 39);
            this.rtbResult.TabIndex = 31;
            this.rtbResult.Text = "";
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(258, 308);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.rtbFactorial_value);
            this.Controls.Add(this.btnParallel_stream);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cuberoot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.exponentiation);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected void KeyPlus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        protected void KeyMinus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }

        protected void KeyMultiply_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }

        protected void KeyDivide_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }

        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        protected void KeyPoint_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        protected void KeyDate_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.GetDate();
            CalcEngine.CalcReset();
        }

        protected void KeyClear_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";

            firstNumder = unRealFirstNumber;
        }

        //
        // Perform the calculation.
        //

        protected void KeyEqual_Click(object sender, System.EventArgs e)
        {
            if (Math.Abs(firstNumder - unRealFirstNumber) < 0.0001)
            {
                OutputDisplay.Text = CalcEngine.CalcEqual();
                CalcEngine.CalcReset();
            }
            else
            {

                double secondNumber = double.Parse(OutputDisplay.Text);
                double result = Math.Pow(firstNumder, secondNumber);
                OutputDisplay.Text = result.ToString();
            }
        }


        //
        // Numeric key click methods.
        //

        protected void KeyNine_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        protected void KeyEight_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        protected void KeySeven_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        protected void KeySix_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        protected void KeyFive_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        protected void KeyFour_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        protected void KeyThree_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        protected void KeyTwo_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        protected void KeyOne_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        protected void KeyZero_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        //
        // End the program.
        //

        protected void KeyExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            Application.Run(new CalcUI());

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = Math.Sqrt(double.Parse(OutputDisplay.Text)).ToString();
        }

        private void exponentiation_Click(object sender, EventArgs e)
        {
            firstNumder = Double.Parse(OutputDisplay.Text);
            CalcEngine.CalcReset();
            OutputDisplay.Text = "";

        }

        private void inverse_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = (1 / double.Parse(OutputDisplay.Text)).ToString();
        }

        private void engineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(278, 430);
        }

        private void usualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(278, 306);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(OutputDisplay.Text);
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            OutputDisplay.Text = factorial.ToString();
        }

        private void cuberoot_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(OutputDisplay.Text);
            double cuberoot = Math.Pow(n, 1.0 / 3.0);
            OutputDisplay.Text = cuberoot.ToString();
        }

        private Quadratic quadratic;

        private void button2_Click(object sender, EventArgs e)
        {
            quadratic = new Quadratic();
            quadratic.StartPosition = FormStartPosition.Manual;
            quadratic.Location = new Point(950, 700);
            quadratic.Show();
        }

        private void parallelFlowCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(278, 500);
        }

        private void rtbFactorial_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Field can only contain numbers");
            }

        }

        public int FactorialFunk(int number)
        {
            int n = number;
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
                Thread.Sleep(2000);
            }

            PrintInrtbResultDelegate delPrint = new PrintInrtbResultDelegate(Print);
            rtbResult.Invoke(delPrint, new object[] { factorial });
            return factorial; 
        }

        public delegate int Factorial(int number);
        public delegate void PrintInrtbResultDelegate(int factorial);

        private void btnParallel_stream_Click(object sender, EventArgs e)
        {

            Factorial fact_delegat = new Factorial(FactorialFunk);
            
            fact_delegat.BeginInvoke(Int32.Parse(rtbFactorial_value.Text), null, null);
        }

        void Print(int factorial)
        {
            rtbResult.AppendText(factorial.ToString());
        }


    }
}
