namespace task_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_rock = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.btn_scissors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_comp = new System.Windows.Forms.PictureBox();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.res_comp = new System.Windows.Forms.Label();
            this.res_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rock
            // 
            this.btn_rock.BackgroundImage = global::task_6.Properties.Resources.rock;
            this.btn_rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rock.Location = new System.Drawing.Point(8, 301);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(160, 149);
            this.btn_rock.TabIndex = 0;
            this.btn_rock.UseVisualStyleBackColor = true;
            this.btn_rock.Click += new System.EventHandler(this.btn_rock_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.BackgroundImage = global::task_6.Properties.Resources.paper;
            this.btn_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_paper.Location = new System.Drawing.Point(174, 301);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(160, 149);
            this.btn_paper.TabIndex = 1;
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // btn_scissors
            // 
            this.btn_scissors.BackgroundImage = global::task_6.Properties.Resources.scissors;
            this.btn_scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_scissors.Location = new System.Drawing.Point(340, 301);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(160, 149);
            this.btn_scissors.TabIndex = 2;
            this.btn_scissors.UseVisualStyleBackColor = true;
            this.btn_scissors.Click += new System.EventHandler(this.btn_scissors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select one of the suggested options:";
            // 
            // pb_comp
            // 
            this.pb_comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_comp.Location = new System.Drawing.Point(33, 97);
            this.pb_comp.Name = "pb_comp";
            this.pb_comp.Size = new System.Drawing.Size(160, 149);
            this.pb_comp.TabIndex = 4;
            this.pb_comp.TabStop = false;
            // 
            // pb_user
            // 
            this.pb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_user.Location = new System.Drawing.Point(313, 97);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(160, 149);
            this.pb_user.TabIndex = 5;
            this.pb_user.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(230, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "VS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(230, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "VS";
            // 
            // res_comp
            // 
            this.res_comp.AutoSize = true;
            this.res_comp.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.res_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.res_comp.Location = new System.Drawing.Point(174, 30);
            this.res_comp.Name = "res_comp";
            this.res_comp.Size = new System.Drawing.Size(33, 37);
            this.res_comp.TabIndex = 8;
            this.res_comp.Text = "0";
            // 
            // res_user
            // 
            this.res_user.AutoSize = true;
            this.res_user.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.res_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.res_user.Location = new System.Drawing.Point(301, 30);
            this.res_user.Name = "res_user";
            this.res_user.Size = new System.Drawing.Size(33, 37);
            this.res_user.TabIndex = 9;
            this.res_user.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(512, 466);
            this.Controls.Add(this.res_user);
            this.Controls.Add(this.res_comp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.pb_comp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_scissors);
            this.Controls.Add(this.btn_paper);
            this.Controls.Add(this.btn_rock);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_rock;
        private Button btn_paper;
        private Button btn_scissors;
        private Label label1;
        private PictureBox pb_comp;
        private PictureBox pb_user;
        private Label label2;
        private Label label3;
        private Label res_comp;
        private Label res_user;
    }
}