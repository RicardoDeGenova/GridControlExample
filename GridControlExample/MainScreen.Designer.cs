
namespace GridControlExample;

partial class MainScreen
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        dataGridViewComBinding = new DataGridView();
        menuStrip = new MenuStrip();
        ExportMenuItem = new ToolStripMenuItem();
        PdfExportMenuItem = new ToolStripMenuItem();
        buttonPopulateGrids = new Button();
        dataGridViewSemBinding = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewComBinding).BeginInit();
        menuStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewSemBinding).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewComBinding
        // 
        dataGridViewComBinding.AllowUserToAddRows = false;
        dataGridViewComBinding.AllowUserToDeleteRows = false;
        dataGridViewComBinding.AllowUserToResizeRows = false;
        dataGridViewComBinding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewComBinding.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewComBinding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewComBinding.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewComBinding.EditMode = DataGridViewEditMode.EditProgrammatically;
        dataGridViewComBinding.Location = new Point(12, 66);
        dataGridViewComBinding.Name = "dataGridViewComBinding";
        dataGridViewComBinding.Size = new Size(1035, 280);
        dataGridViewComBinding.TabIndex = 0;
        // 
        // menuStrip
        // 
        menuStrip.Enabled = false;
        menuStrip.Font = new Font("Segoe UI", 12F);
        menuStrip.Items.AddRange(new ToolStripItem[] { ExportMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(1055, 29);
        menuStrip.TabIndex = 1;
        menuStrip.Text = "menuStrip1";
        // 
        // ExportMenuItem
        // 
        ExportMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PdfExportMenuItem });
        ExportMenuItem.Name = "ExportMenuItem";
        ExportMenuItem.Size = new Size(80, 25);
        ExportMenuItem.Text = "Exportar";
        // 
        // PdfExportMenuItem
        // 
        PdfExportMenuItem.Name = "PdfExportMenuItem";
        PdfExportMenuItem.Size = new Size(108, 26);
        PdfExportMenuItem.Text = "PDF";
        // 
        // buttonPopulateGrids
        // 
        buttonPopulateGrids.Anchor = AnchorStyles.Top;
        buttonPopulateGrids.Location = new Point(466, 32);
        buttonPopulateGrids.Name = "buttonPopulateGrids";
        buttonPopulateGrids.Size = new Size(122, 29);
        buttonPopulateGrids.TabIndex = 2;
        buttonPopulateGrids.Text = "Popula Grids";
        buttonPopulateGrids.UseVisualStyleBackColor = true;
        buttonPopulateGrids.Click += ButtonPopulateGrids_Click;
        // 
        // dataGridViewSemBinding
        // 
        dataGridViewSemBinding.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewSemBinding.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridViewSemBinding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridViewSemBinding.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewSemBinding.Location = new Point(12, 352);
        dataGridViewSemBinding.Name = "dataGridViewSemBinding";
        dataGridViewSemBinding.Size = new Size(1035, 280);
        dataGridViewSemBinding.TabIndex = 0;
        // 
        // MainScreen
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1055, 644);
        Controls.Add(buttonPopulateGrids);
        Controls.Add(dataGridViewSemBinding);
        Controls.Add(dataGridViewComBinding);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        Name = "MainScreen";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridViewComBinding).EndInit();
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewSemBinding).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewComBinding;
    private MenuStrip menuStrip;
    private ToolStripMenuItem ExportMenuItem;
    private ToolStripMenuItem PdfExportMenuItem;
    private Button buttonPopulateGrids;
    private DataGridView dataGridViewSemBinding;
}
