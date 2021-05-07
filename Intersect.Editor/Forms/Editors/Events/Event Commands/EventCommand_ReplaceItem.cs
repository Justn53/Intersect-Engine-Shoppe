using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandReplaceItem : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private ReplaceItemCommand mMyCommand;

        public EventCommandReplaceItem( ReplaceItemCommand refCommand, FrmEvent editor )
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            InitLocalization();
            //Get items
            cmbItems.Items.Clear();
            foreach( var item in ItemBase.ItemPairs )
            {
                cmbItems.Items.Add( item.Value );
            }

            lblReplaceWith.Text = Strings.EventRemoveItem.label;
        }

        private void InitLocalization()
        {
            grpReplaceItem.Text = Strings.EventWait.title;
            lblReplaceWith.Text = Strings.EventWait.label;
            btnSave.Text = Strings.EventWait.okay;
            btnCancel.Text = Strings.EventWait.cancel;
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            var selectedItem = ItemBase.Get( ItemBase.ItemPairs[cmbItems.SelectedIndex].Key );
            mMyCommand.NewItem = selectedItem;
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            mEventEditor.CancelCommandEdit();
        }
    }

}
