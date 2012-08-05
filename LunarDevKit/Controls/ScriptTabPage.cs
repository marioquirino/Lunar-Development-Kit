using System;
using System.Drawing;
using System.Windows.Forms;

namespace LunarDevKit.Controls
{
    using Classes;

    public class ScriptTabPage : TabPage
    {
        #region Fields

        private AssetNode scriptNode;
        private RichTextBox script;

        #endregion

        #region Properties

        public AssetNode ScriptNode
        {
            get { return scriptNode; }
        }

        #endregion

        public ScriptTabPage( AssetNode scriptNode )
        {
            script = new RichTextBox( );
            script.AcceptsTab = true;
            script.AutoWordSelection = true;
            script.DetectUrls = false;
            script.WordWrap = false;
            script.Location = new Point( 0, 0 );
            script.Size = new Size( this.Width, this.Height );
            script.Font = new Font( "Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ( (byte)( 0 ) ) );
            script.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            script.TextChanged += new EventHandler( ScriptTextChanged );
            this.Controls.Add( script );
            
            this.Text = scriptNode.Script.Name;
            this.scriptNode = scriptNode;
            script.Text = scriptNode.Script.ScriptText;
        }

        #region Event Methods

        private void ScriptTextChanged( object sender, EventArgs e )
        {
            this.Text = scriptNode.Script.Name + "*";
        }

        #endregion

        #region Methods

        public void Save( )
        {
            //script.Text += Environment.NewLine + Environment.NewLine + Helper.ConvertScriptToGameScript( script.Text );
            this.Text = scriptNode.Script.Name;
            scriptNode.Script.ScriptText = script.Text;
            FileManager.CreateScriptFile( scriptNode.Script );
        }

        #endregion
    }
}
