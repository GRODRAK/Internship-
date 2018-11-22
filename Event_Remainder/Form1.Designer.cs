namespace Event_Remainder
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.new_eventbt = new System.Windows.Forms.Button();
            this.new_event = new System.Windows.Forms.Label();
            this.vew_event = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Remainter";
            // 
            // new_eventbt
            // 
            this.new_eventbt.Location = new System.Drawing.Point(193, 83);
            this.new_eventbt.Name = "new_eventbt";
            this.new_eventbt.Size = new System.Drawing.Size(84, 23);
            this.new_eventbt.TabIndex = 3;
            this.new_eventbt.Text = "Create Event";
            this.new_eventbt.UseVisualStyleBackColor = true;
            this.new_eventbt.Click += new System.EventHandler(this.new_eventbt_Click);
            // 
            // new_event
            // 
            this.new_event.AutoSize = true;
            this.new_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_event.Location = new System.Drawing.Point(12, 83);
            this.new_event.Name = "new_event";
            this.new_event.Size = new System.Drawing.Size(148, 20);
            this.new_event.TabIndex = 4;
            this.new_event.Text = "Create a new Event";
            // 
            // vew_event
            // 
            this.vew_event.AutoSize = true;
            this.vew_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vew_event.Location = new System.Drawing.Point(12, 121);
            this.vew_event.Name = "vew_event";
            this.vew_event.Size = new System.Drawing.Size(93, 20);
            this.vew_event.TabIndex = 5;
            this.vew_event.Text = "Vew Events";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vew Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edit Event";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 247);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vew_event);
            this.Controls.Add(this.new_event);
            this.Controls.Add(this.new_eventbt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Event Manager";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button new_eventbt;
        private System.Windows.Forms.Label new_event;
        private System.Windows.Forms.Label vew_event;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

