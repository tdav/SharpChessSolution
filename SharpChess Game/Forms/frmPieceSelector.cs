// --------------------------------------------------------------------------------------------------------------------
// <copyright file="frmPieceSelector.cs" company="SharpChess.com">
//   SharpChess.com
// </copyright>
// <summary>
//   Summary description for frmPieceSelector.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region License

// SharpChess
// Copyright (C) 2012 SharpChess.com
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
#endregion

namespace SharpChess
{
    #region Using

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;

    using SharpChess.Model;

    #endregion

    /// <summary>
    /// Summary description for frmPieceSelector.
    /// </summary>
    public class frmPieceSelector : Form
    {
        #region Constants and Fields

        /// <summary>
        ///   Required designer variable.
        /// </summary>
        private readonly Container components = null;

        /// <summary>
        /// The m_ colour.
        /// </summary>
        private Player.PlayerColourNames m_Colour = Player.PlayerColourNames.Black;

        /// <summary>
        /// The m_ move name selected.
        /// </summary>
        private Move.MoveNames m_MoveNameSelected = Model.Move.MoveNames.NullMove;

        /// <summary>
        /// The pic black bishop.
        /// </summary>
        private PictureBox picBlackBishop;

        /// <summary>
        /// The pic black knight.
        /// </summary>
        private PictureBox picBlackKnight;

        /// <summary>
        /// The pic black queen.
        /// </summary>
        private PictureBox picBlackQueen;

        /// <summary>
        /// The pic black rook.
        /// </summary>
        private PictureBox picBlackRook;

        /// <summary>
        /// The pic white bishop.
        /// </summary>
        private PictureBox picWhiteBishop;

        /// <summary>
        /// The pic white knight.
        /// </summary>
        private PictureBox picWhiteKnight;

        /// <summary>
        /// The pic white queen.
        /// </summary>
        private PictureBox picWhiteQueen;

        /// <summary>
        /// The pic white rook.
        /// </summary>
        private PictureBox picWhiteRook;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="frmPieceSelector"/> class.
        /// </summary>
        public frmPieceSelector()
        {
            // Required for Windows Form Designer support
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Sets Colour.
        /// </summary>
        public Player.PlayerColourNames Colour
        {
            set
            {
                this.m_Colour = value;
            }
        }

        /// <summary>
        /// Gets MoveNameSelected.
        /// </summary>
        public Move.MoveNames MoveNameSelected
        {
            get
            {
                return this.m_MoveNameSelected;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        ///   the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPieceSelector));
            this.picWhiteQueen = new System.Windows.Forms.PictureBox();
            this.picWhiteRook = new System.Windows.Forms.PictureBox();
            this.picWhiteBishop = new System.Windows.Forms.PictureBox();
            this.picWhiteKnight = new System.Windows.Forms.PictureBox();
            this.picBlackKnight = new System.Windows.Forms.PictureBox();
            this.picBlackBishop = new System.Windows.Forms.PictureBox();
            this.picBlackRook = new System.Windows.Forms.PictureBox();
            this.picBlackQueen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteRook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteBishop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackBishop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackRook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackQueen)).BeginInit();
            this.SuspendLayout();
            // 
            // picWhiteQueen
            // 
            this.picWhiteQueen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picWhiteQueen.Image = ((System.Drawing.Image)(resources.GetObject("picWhiteQueen.Image")));
            this.picWhiteQueen.Location = new System.Drawing.Point(0, 0);
            this.picWhiteQueen.Name = "picWhiteQueen";
            this.picWhiteQueen.Size = new System.Drawing.Size(50, 52);
            this.picWhiteQueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWhiteQueen.TabIndex = 0;
            this.picWhiteQueen.TabStop = false;
            this.picWhiteQueen.Tag = "Queen";
            this.picWhiteQueen.Visible = false;
            this.picWhiteQueen.Click += new System.EventHandler(this.picPiece_Click);
            this.picWhiteQueen.MouseEnter += new System.EventHandler(this.picMouseEnter);
            this.picWhiteQueen.MouseLeave += new System.EventHandler(this.picMouseLeave);
            // 
            // picWhiteRook
            // 
            this.picWhiteRook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picWhiteRook.Image = ((System.Drawing.Image)(resources.GetObject("picWhiteRook.Image")));
            this.picWhiteRook.Location = new System.Drawing.Point(48, 0);
            this.picWhiteRook.Name = "picWhiteRook";
            this.picWhiteRook.Size = new System.Drawing.Size(50, 52);
            this.picWhiteRook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWhiteRook.TabIndex = 1;
            this.picWhiteRook.TabStop = false;
            this.picWhiteRook.Tag = "Rook";
            this.picWhiteRook.Visible = false;
            this.picWhiteRook.Click += new System.EventHandler(this.picPiece_Click);
            this.picWhiteRook.MouseEnter += new System.EventHandler(this.picMouseEnter);
            this.picWhiteRook.MouseLeave += new System.EventHandler(this.picMouseLeave);
            // 
            // picWhiteBishop
            // 
            this.picWhiteBishop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picWhiteBishop.Image = ((System.Drawing.Image)(resources.GetObject("picWhiteBishop.Image")));
            this.picWhiteBishop.Location = new System.Drawing.Point(96, 0);
            this.picWhiteBishop.Name = "picWhiteBishop";
            this.picWhiteBishop.Size = new System.Drawing.Size(50, 52);
            this.picWhiteBishop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWhiteBishop.TabIndex = 2;
            this.picWhiteBishop.TabStop = false;
            this.picWhiteBishop.Tag = "Bishop";
            this.picWhiteBishop.Visible = false;
            this.picWhiteBishop.Click += new System.EventHandler(this.picPiece_Click);
            this.picWhiteBishop.MouseEnter += new System.EventHandler(this.picMouseEnter);
            this.picWhiteBishop.MouseLeave += new System.EventHandler(this.picMouseLeave);
            // 
            // picWhiteKnight
            // 
            this.picWhiteKnight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picWhiteKnight.Image = ((System.Drawing.Image)(resources.GetObject("picWhiteKnight.Image")));
            this.picWhiteKnight.Location = new System.Drawing.Point(144, 0);
            this.picWhiteKnight.Name = "picWhiteKnight";
            this.picWhiteKnight.Size = new System.Drawing.Size(50, 52);
            this.picWhiteKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWhiteKnight.TabIndex = 3;
            this.picWhiteKnight.TabStop = false;
            this.picWhiteKnight.Tag = "Knight";
            this.picWhiteKnight.Visible = false;
            this.picWhiteKnight.Click += new System.EventHandler(this.picPiece_Click);
            this.picWhiteKnight.MouseEnter += new System.EventHandler(this.picMouseEnter);
            this.picWhiteKnight.MouseLeave += new System.EventHandler(this.picMouseLeave);
            // 
            // picBlackKnight
            // 
            this.picBlackKnight.BackColor = System.Drawing.Color.Transparent;
            this.picBlackKnight.Image = ((System.Drawing.Image)(resources.GetObject("picBlackKnight.Image")));
            this.picBlackKnight.Location = new System.Drawing.Point(144, 0);
            this.picBlackKnight.Name = "picBlackKnight";
            this.picBlackKnight.Size = new System.Drawing.Size(50, 52);
            this.picBlackKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBlackKnight.TabIndex = 7;
            this.picBlackKnight.TabStop = false;
            this.picBlackKnight.Tag = "Knight";
            this.picBlackKnight.Visible = false;
            this.picBlackKnight.Click += new System.EventHandler(this.picPiece_Click);
            this.picBlackKnight.MouseEnter += new System.EventHandler(this.picMouseEnter);
            this.picBlackKnight.MouseLeave += new System.EventHandler(this.picMouseLeave);
            // 
            // picBlackBishop
            // 
            this.picBlackBishop.BackColor = System.Drawing.Color.Transparent;
            this.picBlackBishop.Image = ((System.Drawing.Image)(resources.GetObject("picBlackBishop.Image")));
            this.picBlackBishop.Location = new System.Drawing.Point(96, 0);
            this.picBlackBishop.Name = "picBlackBishop";
            this.picBlackBishop.Size = new System.Drawing.Size(50, 52);
            this.picBlackBishop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBlackBishop.TabIndex = 6;
            this.picBlackBishop.TabStop = false;
            this.picBlackBishop.Tag = "Bishop";
            this.picBlackBishop.Visible = false;
            this.picBlackBishop.Click += new System.EventHandler(this.picPiece_Click);
            this.picBlackBishop.MouseEnter += new System.EventHandler(this.picMouseEnter);
            this.picBlackBishop.MouseLeave += new System.EventHandler(this.picMouseLeave);
            // 
            // picBlackRook
            // 
            this.picBlackRook.BackColor = System.Drawing.Color.Transparent;
            this.picBlackRook.Image = ((System.Drawing.Image)(resources.GetObject("picBlackRook.Image")));
            this.picBlackRook.Location = new System.Drawing.Point(48, 0);
            this.picBlackRook.Name = "picBlackRook";
            this.picBlackRook.Size = new System.Drawing.Size(50, 52);
            this.picBlackRook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBlackRook.TabIndex = 5;
            this.picBlackRook.TabStop = false;
            this.picBlackRook.Tag = "Rook";
            this.picBlackRook.Visible = false;
            this.picBlackRook.Click += new System.EventHandler(this.picPiece_Click);
            this.picBlackRook.MouseEnter += new System.EventHandler(this.picMouseEnter);
            this.picBlackRook.MouseLeave += new System.EventHandler(this.picMouseLeave);
            // 
            // picBlackQueen
            // 
            this.picBlackQueen.BackColor = System.Drawing.Color.Transparent;
            this.picBlackQueen.Image = ((System.Drawing.Image)(resources.GetObject("picBlackQueen.Image")));
            this.picBlackQueen.Location = new System.Drawing.Point(0, 0);
            this.picBlackQueen.Name = "picBlackQueen";
            this.picBlackQueen.Size = new System.Drawing.Size(50, 52);
            this.picBlackQueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBlackQueen.TabIndex = 4;
            this.picBlackQueen.TabStop = false;
            this.picBlackQueen.Tag = "Queen";
            this.picBlackQueen.Visible = false;
            this.picBlackQueen.Click += new System.EventHandler(this.picPiece_Click);
            this.picBlackQueen.MouseEnter += new System.EventHandler(this.picMouseEnter);
            this.picBlackQueen.MouseLeave += new System.EventHandler(this.picMouseLeave);
            // 
            // frmPieceSelector
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(197)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(198, 52);
            this.Controls.Add(this.picBlackKnight);
            this.Controls.Add(this.picBlackBishop);
            this.Controls.Add(this.picBlackRook);
            this.Controls.Add(this.picBlackQueen);
            this.Controls.Add(this.picWhiteKnight);
            this.Controls.Add(this.picWhiteBishop);
            this.Controls.Add(this.picWhiteRook);
            this.Controls.Add(this.picWhiteQueen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPieceSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Promote pawn to?";
            this.Load += new System.EventHandler(this.frmPieceSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteRook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteBishop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackBishop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackRook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackQueen)).EndInit();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// The frm piece selector_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void frmPieceSelector_Load(object sender, EventArgs e)
        {
            switch (this.m_Colour)
            {
                case Player.PlayerColourNames.White:
                    this.picWhiteQueen.Visible = true;
                    this.picWhiteRook.Visible = true;
                    this.picWhiteBishop.Visible = true;
                    this.picWhiteKnight.Visible = true;
                    break;

                case Player.PlayerColourNames.Black:
                    this.picBlackQueen.Visible = true;
                    this.picBlackRook.Visible = true;
                    this.picBlackBishop.Visible = true;
                    this.picBlackKnight.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// The pic mouse enter.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void picMouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Yellow;
        }

        /// <summary>
        /// The pic mouse leave.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void picMouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(255, 128, 0);
        }

        /// <summary>
        /// The pic piece_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void picPiece_Click(object sender, EventArgs e)
        {
            switch ((string)((PictureBox)sender).Tag)
            {
                case "Queen":
                    this.m_MoveNameSelected = Model.Move.MoveNames.PawnPromotionQueen;
                    break;

                case "Rook":
                    this.m_MoveNameSelected = Model.Move.MoveNames.PawnPromotionRook;
                    break;

                case "Bishop":
                    this.m_MoveNameSelected = Model.Move.MoveNames.PawnPromotionBishop;
                    break;

                case "Knight":
                    this.m_MoveNameSelected = Model.Move.MoveNames.PawnPromotionKnight;
                    break;
            }

            this.Close();
        }

        #endregion
    }
}