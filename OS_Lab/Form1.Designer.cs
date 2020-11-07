namespace OS_Lab1
{
    partial class processApp
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
            this.startButton = new System.Windows.Forms.Button();
            this.minComp = new System.Windows.Forms.TextBox();
            this.maxProcesses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxComp = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.logBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.avDelayBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complexityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleyedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeworkedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(16, 487);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(708, 48);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // minComp
            // 
            this.minComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minComp.Location = new System.Drawing.Point(409, 438);
            this.minComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minComp.Name = "minComp";
            this.minComp.Size = new System.Drawing.Size(132, 34);
            this.minComp.TabIndex = 3;
            this.minComp.Text = "500";
            this.minComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxProcesses
            // 
            this.maxProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxProcesses.Location = new System.Drawing.Point(409, 390);
            this.maxProcesses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxProcesses.Name = "maxProcesses";
            this.maxProcesses.Size = new System.Drawing.Size(132, 34);
            this.maxProcesses.TabIndex = 4;
            this.maxProcesses.Text = "10";
            this.maxProcesses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "max processes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(551, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "complexity";
            // 
            // maxComp
            // 
            this.maxComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxComp.Location = new System.Drawing.Point(585, 438);
            this.maxComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxComp.Name = "maxComp";
            this.maxComp.Size = new System.Drawing.Size(132, 34);
            this.maxComp.TabIndex = 7;
            this.maxComp.Text = "5000";
            this.maxComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(909, 439);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(73, 31);
            this.timerLabel.TabIndex = 10;
            this.timerLabel.Text = "time:";
            // 
            // timerBox
            // 
            this.timerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox.Location = new System.Drawing.Point(1021, 437);
            this.timerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timerBox.Name = "timerBox";
            this.timerBox.ReadOnly = true;
            this.timerBox.Size = new System.Drawing.Size(347, 34);
            this.timerBox.TabIndex = 9;
            this.timerBox.Text = "0";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(732, 487);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resetButton.Size = new System.Drawing.Size(708, 48);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Stop";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(732, 0);
            this.logBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(707, 367);
            this.logBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.complexityDataGridViewTextBoxColumn,
            this.deleyedDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.timeworkedDataGridViewTextBoxColumn,
            this.finishDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.processBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(724, 368);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(267, 454);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "(msec)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(361, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(361, 444);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(747, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "avrg. delay:";
            // 
            // avDelayBox
            // 
            this.avDelayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avDelayBox.Location = new System.Drawing.Point(1021, 396);
            this.avDelayBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avDelayBox.Name = "avDelayBox";
            this.avDelayBox.ReadOnly = true;
            this.avDelayBox.Size = new System.Drawing.Size(347, 34);
            this.avDelayBox.TabIndex = 18;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 20;
            // 
            // complexityDataGridViewTextBoxColumn
            // 
            this.complexityDataGridViewTextBoxColumn.DataPropertyName = "complexity";
            this.complexityDataGridViewTextBoxColumn.HeaderText = "complexity";
            this.complexityDataGridViewTextBoxColumn.Name = "complexityDataGridViewTextBoxColumn";
            this.complexityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleyedDataGridViewTextBoxColumn
            // 
            this.deleyedDataGridViewTextBoxColumn.DataPropertyName = "deleyed";
            this.deleyedDataGridViewTextBoxColumn.HeaderText = "deleyed";
            this.deleyedDataGridViewTextBoxColumn.Name = "deleyedDataGridViewTextBoxColumn";
            this.deleyedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeworkedDataGridViewTextBoxColumn
            // 
            this.timeworkedDataGridViewTextBoxColumn.DataPropertyName = "time_worked";
            this.timeworkedDataGridViewTextBoxColumn.HeaderText = "time_worked";
            this.timeworkedDataGridViewTextBoxColumn.Name = "timeworkedDataGridViewTextBoxColumn";
            this.timeworkedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishDataGridViewTextBoxColumn
            // 
            this.finishDataGridViewTextBoxColumn.DataPropertyName = "finish";
            this.finishDataGridViewTextBoxColumn.HeaderText = "finish";
            this.finishDataGridViewTextBoxColumn.Name = "finishDataGridViewTextBoxColumn";
            this.finishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataSource = typeof(OS_Lab1.Process);
            // 
            // processApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 558);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.avDelayBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxProcesses);
            this.Controls.Add(this.minComp);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1461, 605);
            this.MinimumSize = new System.Drawing.Size(1461, 605);
            this.Name = "processApp";
            this.ShowIcon = false;
            this.Text = "Oparation Systems Lab_1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox minComp;
        private System.Windows.Forms.TextBox maxProcesses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxComp;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.BindingSource processBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox avDelayBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complexityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleyedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeworkedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDataGridViewTextBoxColumn;
    }
}

