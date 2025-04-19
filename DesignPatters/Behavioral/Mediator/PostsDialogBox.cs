using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Mediator
{
    public class PostsDialogBox:DialogBox
    {
        private ListBox _postsListBox;

        private TextBox _titleTextBox;

        private Button _saveButton;


        public PostsDialogBox()
        {
            _postsListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);

            _saveButton.SetEnabled(false);
        }

        public void SimulateUserIntraction()
        {
            _postsListBox.SetSelection("Post 2");
            _titleTextBox.SetText("");
             Console.WriteLine("Title text box: " + _titleTextBox.GetText());
             Console.WriteLine("Button enabled: " + _saveButton.isEnabled());

        }

        public override void Change(UIControl uiControl)
        {
           if(uiControl == _postsListBox)
            {
                HandlePostChanged();

            }
            else if(uiControl == _titleTextBox)
            {
                HandleTitleChanged();
            }
        }

        private void HandlePostChanged()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void HandleTitleChanged()
        {
            bool isTitleİsEmpty = _titleTextBox.GetText() == "";

            _saveButton.SetEnabled(!isTitleİsEmpty);
        }
    }
}
