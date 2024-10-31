namespace Chart_Uı
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.aProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.bProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.cProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.LblA = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblB = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblC = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnStart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // aProgress
            // 
            this.aProgress.Animated = false;
            this.aProgress.AnimationInterval = 1;
            this.aProgress.AnimationSpeed = 1;
            this.aProgress.BackColor = System.Drawing.Color.Transparent;
            this.aProgress.CircleMargin = 10;
            this.aProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.aProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aProgress.IsPercentage = false;
            this.aProgress.LineProgressThickness = 10;
            this.aProgress.LineThickness = 10;
            this.aProgress.Location = new System.Drawing.Point(86, 49);
            this.aProgress.Name = "aProgress";
            this.aProgress.ProgressAnimationSpeed = 200;
            this.aProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.aProgress.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.aProgress.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.aProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.aProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.aProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.aProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.aProgress.Size = new System.Drawing.Size(150, 150);
            this.aProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.aProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.aProgress.SubScriptText = ".";
            this.aProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.aProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.aProgress.SuperScriptText = "";
            this.aProgress.TabIndex = 16;
            this.aProgress.Text = "0";
            this.aProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.aProgress.ValueByTransition = 0;
            this.aProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // bProgress
            // 
            this.bProgress.Animated = false;
            this.bProgress.AnimationInterval = 1;
            this.bProgress.AnimationSpeed = 1;
            this.bProgress.BackColor = System.Drawing.Color.Transparent;
            this.bProgress.CircleMargin = 10;
            this.bProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bProgress.IsPercentage = false;
            this.bProgress.LineProgressThickness = 10;
            this.bProgress.LineThickness = 10;
            this.bProgress.Location = new System.Drawing.Point(322, 49);
            this.bProgress.Name = "bProgress";
            this.bProgress.ProgressAnimationSpeed = 200;
            this.bProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bProgress.ProgressColor = System.Drawing.Color.BlueViolet;
            this.bProgress.ProgressColor2 = System.Drawing.Color.MediumPurple;
            this.bProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bProgress.Size = new System.Drawing.Size(150, 150);
            this.bProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bProgress.SubScriptText = ".";
            this.bProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bProgress.SuperScriptText = "";
            this.bProgress.TabIndex = 17;
            this.bProgress.Text = "0";
            this.bProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bProgress.ValueByTransition = 0;
            this.bProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // cProgress
            // 
            this.cProgress.Animated = false;
            this.cProgress.AnimationInterval = 1;
            this.cProgress.AnimationSpeed = 1;
            this.cProgress.BackColor = System.Drawing.Color.Transparent;
            this.cProgress.CircleMargin = 10;
            this.cProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.cProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cProgress.IsPercentage = false;
            this.cProgress.LineProgressThickness = 10;
            this.cProgress.LineThickness = 10;
            this.cProgress.Location = new System.Drawing.Point(557, 49);
            this.cProgress.Name = "cProgress";
            this.cProgress.ProgressAnimationSpeed = 200;
            this.cProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cProgress.ProgressColor = System.Drawing.Color.Green;
            this.cProgress.ProgressColor2 = System.Drawing.Color.SeaGreen;
            this.cProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.cProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.cProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.cProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cProgress.Size = new System.Drawing.Size(150, 150);
            this.cProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.cProgress.SubScriptText = ".";
            this.cProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.cProgress.SuperScriptText = "";
            this.cProgress.TabIndex = 18;
            this.cProgress.Text = "0";
            this.cProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cProgress.ValueByTransition = 0;
            this.cProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // LblA
            // 
            this.LblA.AllowParentOverrides = false;
            this.LblA.AutoEllipsis = false;
            this.LblA.CursorType = null;
            this.LblA.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.LblA.Location = new System.Drawing.Point(128, 216);
            this.LblA.Name = "LblA";
            this.LblA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblA.Size = new System.Drawing.Size(63, 18);
            this.LblA.TabIndex = 19;
            this.LblA.Text = "A Team";
            this.LblA.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblA.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblB
            // 
            this.lblB.AllowParentOverrides = false;
            this.lblB.AutoEllipsis = false;
            this.lblB.CursorType = null;
            this.lblB.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblB.Location = new System.Drawing.Point(371, 216);
            this.lblB.Name = "lblB";
            this.lblB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblB.Size = new System.Drawing.Size(62, 18);
            this.lblB.TabIndex = 20;
            this.lblB.Text = "B Team";
            this.lblB.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblB.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblC
            // 
            this.lblC.AllowParentOverrides = false;
            this.lblC.AutoEllipsis = false;
            this.lblC.CursorType = null;
            this.lblC.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblC.Location = new System.Drawing.Point(606, 216);
            this.lblC.Name = "lblC";
            this.lblC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblC.Size = new System.Drawing.Size(62, 18);
            this.lblC.TabIndex = 21;
            this.lblC.Text = "C Team";
            this.lblC.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblC.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnStart
            // 
            this.btnStart.AllowAnimations = true;
            this.btnStart.AllowMouseEffects = true;
            this.btnStart.AllowToggling = false;
            this.btnStart.AnimationSpeed = 200;
            this.btnStart.AutoGenerateColors = false;
            this.btnStart.AutoRoundBorders = false;
            this.btnStart.AutoSizeLeftIcon = true;
            this.btnStart.AutoSizeRightIcon = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackColor1 = System.Drawing.Color.DarkViolet;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnStart.ButtonText = "Start";
            this.btnStart.ButtonTextMarginLeft = 0;
            this.btnStart.ColorContrastOnClick = 45;
            this.btnStart.ColorContrastOnHover = 45;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnStart.CustomizableEdges = borderEdges1;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStart.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStart.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnStart.IconMarginLeft = 11;
            this.btnStart.IconPadding = 10;
            this.btnStart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnStart.IconSize = 25;
            this.btnStart.IdleBorderColor = System.Drawing.Color.MediumOrchid;
            this.btnStart.IdleBorderRadius = 1;
            this.btnStart.IdleBorderThickness = 1;
            this.btnStart.IdleFillColor = System.Drawing.Color.DarkViolet;
            this.btnStart.IdleIconLeftImage = null;
            this.btnStart.IdleIconRightImage = null;
            this.btnStart.IndicateFocus = false;
            this.btnStart.Location = new System.Drawing.Point(322, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStart.OnDisabledState.BorderRadius = 1;
            this.btnStart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnStart.OnDisabledState.BorderThickness = 1;
            this.btnStart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStart.OnDisabledState.IconLeftImage = null;
            this.btnStart.OnDisabledState.IconRightImage = null;
            this.btnStart.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnStart.onHoverState.BorderRadius = 1;
            this.btnStart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnStart.onHoverState.BorderThickness = 1;
            this.btnStart.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnStart.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnStart.onHoverState.IconLeftImage = null;
            this.btnStart.onHoverState.IconRightImage = null;
            this.btnStart.OnIdleState.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnStart.OnIdleState.BorderRadius = 1;
            this.btnStart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnStart.OnIdleState.BorderThickness = 1;
            this.btnStart.OnIdleState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnStart.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnStart.OnIdleState.IconLeftImage = null;
            this.btnStart.OnIdleState.IconRightImage = null;
            this.btnStart.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnStart.OnPressedState.BorderRadius = 1;
            this.btnStart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnStart.OnPressedState.BorderThickness = 1;
            this.btnStart.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnStart.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnStart.OnPressedState.IconLeftImage = null;
            this.btnStart.OnPressedState.IconRightImage = null;
            this.btnStart.Size = new System.Drawing.Size(150, 39);
            this.btnStart.TabIndex = 22;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStart.TextMarginLeft = 0;
            this.btnStart.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnStart.UseDefaultRadiusAndThickness = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AllowParentOverrides = false;
            this.lblTime.AutoEllipsis = false;
            this.lblTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(86, 337);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(0, 0);
            this.lblTime.TabIndex = 23;
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.cProgress);
            this.Controls.Add(this.bProgress);
            this.Controls.Add(this.aProgress);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuCircleProgress aProgress;
        private Bunifu.UI.WinForms.BunifuCircleProgress bProgress;
        private Bunifu.UI.WinForms.BunifuCircleProgress cProgress;
        private Bunifu.UI.WinForms.BunifuLabel LblA;
        private Bunifu.UI.WinForms.BunifuLabel lblB;
        private Bunifu.UI.WinForms.BunifuLabel lblC;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnStart;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
    }
}