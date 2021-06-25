
namespace ProjektMagazyn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btReceive = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.grbxOrder = new System.Windows.Forms.GroupBox();
            this.dtpOrderPack = new System.Windows.Forms.DateTimePicker();
            this.txbOrderPackSize = new System.Windows.Forms.TextBox();
            this.txbOrderPackFrom = new System.Windows.Forms.TextBox();
            this.txbOrderPackName = new System.Windows.Forms.TextBox();
            this.txbOrderPackID = new System.Windows.Forms.TextBox();
            this.btAddOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbxSend = new System.Windows.Forms.GroupBox();
            this.txbSendPackDestination = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpSendPack = new System.Windows.Forms.DateTimePicker();
            this.txbSendPackID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btAddSend = new System.Windows.Forms.Button();
            this.grbxReceive = new System.Windows.Forms.GroupBox();
            this.txbReceivePackID = new System.Windows.Forms.TextBox();
            this.btAddReceive = new System.Windows.Forms.Button();
            this.dtpReceivePack = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.grbxDelete = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbDeletePackID = new System.Windows.Forms.TextBox();
            this.btRemovePack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbxOrder.SuspendLayout();
            this.grbxSend.SuspendLayout();
            this.grbxReceive.SuspendLayout();
            this.grbxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(751, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // btReceive
            // 
            this.btReceive.Location = new System.Drawing.Point(12, 201);
            this.btReceive.Name = "btReceive";
            this.btReceive.Size = new System.Drawing.Size(173, 45);
            this.btReceive.TabIndex = 1;
            this.btReceive.Text = "Odbierz Paczkę";
            this.btReceive.UseVisualStyleBackColor = true;
            this.btReceive.Click += new System.EventHandler(this.btReceive_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(12, 264);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(173, 44);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Wyślij Paczkę";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(12, 325);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(173, 46);
            this.btOrder.TabIndex = 3;
            this.btOrder.Text = "Zamów paczkę";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(11, 450);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(172, 46);
            this.btShow.TabIndex = 4;
            this.btShow.Text = "Wyświetl Magazyn";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // grbxOrder
            // 
            this.grbxOrder.Controls.Add(this.dtpOrderPack);
            this.grbxOrder.Controls.Add(this.txbOrderPackSize);
            this.grbxOrder.Controls.Add(this.txbOrderPackFrom);
            this.grbxOrder.Controls.Add(this.txbOrderPackName);
            this.grbxOrder.Controls.Add(this.txbOrderPackID);
            this.grbxOrder.Controls.Add(this.btAddOrder);
            this.grbxOrder.Controls.Add(this.label5);
            this.grbxOrder.Controls.Add(this.label4);
            this.grbxOrder.Controls.Add(this.label3);
            this.grbxOrder.Controls.Add(this.label2);
            this.grbxOrder.Controls.Add(this.label1);
            this.grbxOrder.Location = new System.Drawing.Point(12, 12);
            this.grbxOrder.Name = "grbxOrder";
            this.grbxOrder.Size = new System.Drawing.Size(602, 155);
            this.grbxOrder.TabIndex = 5;
            this.grbxOrder.TabStop = false;
            this.grbxOrder.Text = "Zamów Paczkę";
            // 
            // dtpOrderPack
            // 
            this.dtpOrderPack.CustomFormat = "yyyy-MM-dd";
            this.dtpOrderPack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderPack.Location = new System.Drawing.Point(423, 62);
            this.dtpOrderPack.Name = "dtpOrderPack";
            this.dtpOrderPack.Size = new System.Drawing.Size(138, 27);
            this.dtpOrderPack.TabIndex = 10;
            // 
            // txbOrderPackSize
            // 
            this.txbOrderPackSize.Location = new System.Drawing.Point(422, 24);
            this.txbOrderPackSize.Name = "txbOrderPackSize";
            this.txbOrderPackSize.Size = new System.Drawing.Size(139, 27);
            this.txbOrderPackSize.TabIndex = 9;
            // 
            // txbOrderPackFrom
            // 
            this.txbOrderPackFrom.Location = new System.Drawing.Point(111, 97);
            this.txbOrderPackFrom.Name = "txbOrderPackFrom";
            this.txbOrderPackFrom.Size = new System.Drawing.Size(168, 27);
            this.txbOrderPackFrom.TabIndex = 8;
            // 
            // txbOrderPackName
            // 
            this.txbOrderPackName.Location = new System.Drawing.Point(111, 59);
            this.txbOrderPackName.Name = "txbOrderPackName";
            this.txbOrderPackName.Size = new System.Drawing.Size(168, 27);
            this.txbOrderPackName.TabIndex = 7;
            // 
            // txbOrderPackID
            // 
            this.txbOrderPackID.Location = new System.Drawing.Point(111, 24);
            this.txbOrderPackID.MaxLength = 4;
            this.txbOrderPackID.Name = "txbOrderPackID";
            this.txbOrderPackID.Size = new System.Drawing.Size(168, 27);
            this.txbOrderPackID.TabIndex = 6;
            this.txbOrderPackID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbOrderPackID_KeyPress);
            // 
            // btAddOrder
            // 
            this.btAddOrder.Location = new System.Drawing.Point(437, 120);
            this.btAddOrder.Name = "btAddOrder";
            this.btAddOrder.Size = new System.Drawing.Size(94, 29);
            this.btAddOrder.TabIndex = 5;
            this.btAddOrder.Text = "Zamów";
            this.btAddOrder.UseVisualStyleBackColor = true;
            this.btAddOrder.Click += new System.EventHandler(this.btAddOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Zamówienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wielkość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Skąd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa Paczki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr Paczki";
            // 
            // grbxSend
            // 
            this.grbxSend.Controls.Add(this.txbSendPackDestination);
            this.grbxSend.Controls.Add(this.label8);
            this.grbxSend.Controls.Add(this.dtpSendPack);
            this.grbxSend.Controls.Add(this.txbSendPackID);
            this.grbxSend.Controls.Add(this.label7);
            this.grbxSend.Controls.Add(this.label6);
            this.grbxSend.Controls.Add(this.btAddSend);
            this.grbxSend.Location = new System.Drawing.Point(620, 12);
            this.grbxSend.Name = "grbxSend";
            this.grbxSend.Size = new System.Drawing.Size(283, 168);
            this.grbxSend.TabIndex = 6;
            this.grbxSend.TabStop = false;
            this.grbxSend.Text = "Wyślij Paczkę";
            // 
            // txbSendPackDestination
            // 
            this.txbSendPackDestination.Location = new System.Drawing.Point(116, 90);
            this.txbSendPackDestination.Name = "txbSendPackDestination";
            this.txbSendPackDestination.Size = new System.Drawing.Size(138, 27);
            this.txbSendPackDestination.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dokąd";
            // 
            // dtpSendPack
            // 
            this.dtpSendPack.CustomFormat = "yyyy-MM-dd";
            this.dtpSendPack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSendPack.Location = new System.Drawing.Point(116, 56);
            this.dtpSendPack.Name = "dtpSendPack";
            this.dtpSendPack.Size = new System.Drawing.Size(138, 27);
            this.dtpSendPack.TabIndex = 11;
            // 
            // txbSendPackID
            // 
            this.txbSendPackID.Location = new System.Drawing.Point(116, 23);
            this.txbSendPackID.MaxLength = 4;
            this.txbSendPackID.Name = "txbSendPackID";
            this.txbSendPackID.Size = new System.Drawing.Size(138, 27);
            this.txbSendPackID.TabIndex = 3;
            this.txbSendPackID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSendPackID_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data Wyslania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nr Paczki";
            // 
            // btAddSend
            // 
            this.btAddSend.Location = new System.Drawing.Point(135, 133);
            this.btAddSend.Name = "btAddSend";
            this.btAddSend.Size = new System.Drawing.Size(94, 29);
            this.btAddSend.TabIndex = 0;
            this.btAddSend.Text = "Wyślij";
            this.btAddSend.UseVisualStyleBackColor = true;
            this.btAddSend.Click += new System.EventHandler(this.btAddSend_Click);
            // 
            // grbxReceive
            // 
            this.grbxReceive.Controls.Add(this.txbReceivePackID);
            this.grbxReceive.Controls.Add(this.btAddReceive);
            this.grbxReceive.Controls.Add(this.dtpReceivePack);
            this.grbxReceive.Controls.Add(this.label10);
            this.grbxReceive.Controls.Add(this.label9);
            this.grbxReceive.Location = new System.Drawing.Point(273, 363);
            this.grbxReceive.Name = "grbxReceive";
            this.grbxReceive.Size = new System.Drawing.Size(286, 163);
            this.grbxReceive.TabIndex = 7;
            this.grbxReceive.TabStop = false;
            this.grbxReceive.Text = "Odbierz Paczkę";
            // 
            // txbReceivePackID
            // 
            this.txbReceivePackID.Location = new System.Drawing.Point(126, 27);
            this.txbReceivePackID.MaxLength = 4;
            this.txbReceivePackID.Name = "txbReceivePackID";
            this.txbReceivePackID.Size = new System.Drawing.Size(138, 27);
            this.txbReceivePackID.TabIndex = 14;
            this.txbReceivePackID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbReceivePackID_KeyPress);
            // 
            // btAddReceive
            // 
            this.btAddReceive.Location = new System.Drawing.Point(170, 128);
            this.btAddReceive.Name = "btAddReceive";
            this.btAddReceive.Size = new System.Drawing.Size(94, 29);
            this.btAddReceive.TabIndex = 13;
            this.btAddReceive.Text = "Odbierz";
            this.btAddReceive.UseVisualStyleBackColor = true;
            this.btAddReceive.Click += new System.EventHandler(this.btAddReceive_Click);
            // 
            // dtpReceivePack
            // 
            this.dtpReceivePack.CustomFormat = "yyyy-MM-dd";
            this.dtpReceivePack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceivePack.Location = new System.Drawing.Point(126, 72);
            this.dtpReceivePack.Name = "dtpReceivePack";
            this.dtpReceivePack.Size = new System.Drawing.Size(138, 27);
            this.dtpReceivePack.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Data Odebrania";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nr Paczki";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 389);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(173, 45);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Usuń paczkę";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // grbxDelete
            // 
            this.grbxDelete.Controls.Add(this.btRemovePack);
            this.grbxDelete.Controls.Add(this.txbDeletePackID);
            this.grbxDelete.Controls.Add(this.label11);
            this.grbxDelete.Location = new System.Drawing.Point(655, 363);
            this.grbxDelete.Name = "grbxDelete";
            this.grbxDelete.Size = new System.Drawing.Size(231, 157);
            this.grbxDelete.TabIndex = 9;
            this.grbxDelete.TabStop = false;
            this.grbxDelete.Text = "Usuń Paczkę";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nr Paczki";
            // 
            // txbDeletePackID
            // 
            this.txbDeletePackID.Location = new System.Drawing.Point(82, 27);
            this.txbDeletePackID.MaxLength = 4;
            this.txbDeletePackID.Name = "txbDeletePackID";
            this.txbDeletePackID.Size = new System.Drawing.Size(125, 27);
            this.txbDeletePackID.TabIndex = 1;
            this.txbDeletePackID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDeletePackID_KeyPress);
            // 
            // btRemovePack
            // 
            this.btRemovePack.Location = new System.Drawing.Point(65, 104);
            this.btRemovePack.Name = "btRemovePack";
            this.btRemovePack.Size = new System.Drawing.Size(101, 29);
            this.btRemovePack.TabIndex = 2;
            this.btRemovePack.Text = "Usuń paczkę";
            this.btRemovePack.UseVisualStyleBackColor = true;
            this.btRemovePack.Click += new System.EventHandler(this.btRemovePack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 566);
            this.Controls.Add(this.grbxDelete);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.grbxReceive);
            this.Controls.Add(this.grbxSend);
            this.Controls.Add(this.grbxOrder);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btReceive);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Zarządzanie Magazynem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbxOrder.ResumeLayout(false);
            this.grbxOrder.PerformLayout();
            this.grbxSend.ResumeLayout(false);
            this.grbxSend.PerformLayout();
            this.grbxReceive.ResumeLayout(false);
            this.grbxReceive.PerformLayout();
            this.grbxDelete.ResumeLayout(false);
            this.grbxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btReceive;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.GroupBox grbxOrder;
        private System.Windows.Forms.DateTimePicker dtpOrderPack;
        private System.Windows.Forms.TextBox txbOrderPackSize;
        private System.Windows.Forms.TextBox txbOrderPackFrom;
        private System.Windows.Forms.TextBox txbOrderPackName;
        private System.Windows.Forms.TextBox txbOrderPackID;
        private System.Windows.Forms.Button btAddOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbxSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAddSend;
        private System.Windows.Forms.TextBox txbSendPackID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSendPack;
        private System.Windows.Forms.TextBox txbSendPackDestination;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbxReceive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbReceivePackID;
        private System.Windows.Forms.Button btAddReceive;
        private System.Windows.Forms.DateTimePicker dtpReceivePack;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox grbxDelete;
        private System.Windows.Forms.Button btRemovePack;
        private System.Windows.Forms.TextBox txbDeletePackID;
        private System.Windows.Forms.Label label11;
    }
}

