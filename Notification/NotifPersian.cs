using System.Media;
using System.Windows.Forms;

namespace NotifPersian
{
    public class NotifPersian
    {

        public static DialogResult Show(string Message)
        {
            frmView msgBox = new frmView
            {
                Text = "اطلاعات"
            };
            msgBox.Label.Text = Message;
            msgBox.icon.Image = global::NotifPersian.Properties.Resources.info;
            msgBox.OKPanel.Tag = "OK";
            msgBox.OKPanel.Left = 13;
            msgBox.OKPanel.Top = 88;
            msgBox.OKPanel.BringToFront();
            SystemSounds.Asterisk.Play();
            msgBox.ShowDialog();
            return msgBox.Result;
        }
        public static DialogResult Show(string Message, string Title)
        {
            frmView msgBox = new frmView
            {
                Text = Title
            };
            msgBox.Label.Text = Message;
            msgBox.icon.Image = global::NotifPersian.Properties.Resources.info;
            msgBox.OKPanel.Tag = "OK";
            msgBox.OKPanel.Left = 13;
            msgBox.OKPanel.Top = 88;
            msgBox.OKPanel.BringToFront();
            SystemSounds.Asterisk.Play();
            msgBox.ShowDialog();
            return msgBox.Result;
        }
        public static DialogResult Show(string Message, string Title, NotifPersianButtons buttons)
        {
            frmView msgBox = new frmView
            {
                Text = Title
            };
            msgBox.Label.Text = Message;
            msgBox.icon.Image = global::NotifPersian.Properties.Resources.info;
            if (buttons == NotifPersianButtons.OK)
            {
                msgBox.OKPanel.Tag = "OK";
                msgBox.OKPanel.Left = 13;
                msgBox.OKPanel.Top = 88;
                msgBox.OKPanel.BringToFront();
                SystemSounds.Asterisk.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == NotifPersianButtons.OKCancel)
            {
                msgBox.OKCancelPanel.Tag = "OK";
                msgBox.OKCancelPanel.Left = 13;
                msgBox.OKCancelPanel.Top = 88;
                msgBox.OKCancelPanel.BringToFront();
                SystemSounds.Asterisk.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == NotifPersianButtons.RetryCancel)
            {
                msgBox.RetryCancelPanel.Tag = "OK";
                msgBox.RetryCancelPanel.Left = 13;
                msgBox.RetryCancelPanel.Top = 88;
                msgBox.RetryCancelPanel.BringToFront();
                SystemSounds.Asterisk.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == NotifPersianButtons.YesNo)
            {
                msgBox.YesNoPanel.Tag = "OK";
                msgBox.YesNoPanel.Left = 13;
                msgBox.YesNoPanel.Top = 88;
                msgBox.YesNoPanel.BringToFront();
                SystemSounds.Asterisk.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == NotifPersianButtons.YesNoCancel)
            {
                msgBox.YesNoCancelPanel.Tag = "OK";
                msgBox.YesNoCancelPanel.Left = 13;
                msgBox.YesNoCancelPanel.Top = 88;
                msgBox.YesNoCancelPanel.BringToFront();
                SystemSounds.Asterisk.Play();
                msgBox.ShowDialog();
            }
            return msgBox.Result;
        }
        public static DialogResult Show(string Message, string Title, NotifPersianButtons buttons, NotifPersianIcons icon)
        {
            frmView msgBox = new frmView
            {
                Text = Title
            };
            msgBox.Label.Text = Message;

            if (icon == NotifPersianIcons.Error)
                msgBox.icon.Image = global::NotifPersian.Properties.Resources.error;
            else if (icon == NotifPersianIcons.Information)
                msgBox.icon.Image = global::NotifPersian.Properties.Resources.info;
            else if (icon == NotifPersianIcons.Question)
                msgBox.icon.Image = global::NotifPersian.Properties.Resources.question;
            else if (icon == NotifPersianIcons.Warning)
                msgBox.icon.Image = global::NotifPersian.Properties.Resources.warning;


            if (buttons == NotifPersianButtons.OK)
            {
                msgBox.OKPanel.Tag = "OK";
                msgBox.OKPanel.Left = 13;
                msgBox.OKPanel.Top = 88;
                msgBox.OKPanel.BringToFront();
                if (icon == NotifPersianIcons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == NotifPersianIcons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == NotifPersianIcons.Question)
                    SystemSounds.Question.Play();
                else if (icon == NotifPersianIcons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == NotifPersianButtons.OKCancel)
            {
                msgBox.OKCancelPanel.Tag = "OK";
                msgBox.OKCancelPanel.Left = 13;
                msgBox.OKCancelPanel.Top = 88;
                msgBox.OKCancelPanel.BringToFront();
                if (icon == NotifPersianIcons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == NotifPersianIcons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == NotifPersianIcons.Question)
                    SystemSounds.Question.Play();
                else if (icon == NotifPersianIcons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == NotifPersianButtons.RetryCancel)
            {
                msgBox.RetryCancelPanel.Tag = "OK";
                msgBox.RetryCancelPanel.Left = 13;
                msgBox.RetryCancelPanel.Top = 88;
                msgBox.RetryCancelPanel.BringToFront();
                if (icon == NotifPersianIcons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == NotifPersianIcons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == NotifPersianIcons.Question)
                    SystemSounds.Question.Play();
                else if (icon == NotifPersianIcons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == NotifPersianButtons.YesNo)
            {
                msgBox.YesNoPanel.Tag = "OK";
                msgBox.YesNoPanel.Left = 13;
                msgBox.YesNoPanel.Top = 88;
                msgBox.YesNoPanel.BringToFront();
                if (icon == NotifPersianIcons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == NotifPersianIcons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == NotifPersianIcons.Question)
                    SystemSounds.Question.Play();
                else if (icon == NotifPersianIcons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            else if (buttons == NotifPersianButtons.YesNoCancel)
            {
                msgBox.YesNoCancelPanel.Tag = "OK";
                msgBox.YesNoCancelPanel.Left = 13;
                msgBox.YesNoCancelPanel.Top = 88;
                msgBox.YesNoCancelPanel.BringToFront();
                if (icon == NotifPersianIcons.Error)
                    SystemSounds.Hand.Play();
                else if (icon == NotifPersianIcons.Information)
                    SystemSounds.Asterisk.Play();
                else if (icon == NotifPersianIcons.Question)
                    SystemSounds.Question.Play();
                else if (icon == NotifPersianIcons.Warning)
                    SystemSounds.Exclamation.Play();
                msgBox.ShowDialog();
            }
            return msgBox.Result;
        }

    }

    public enum NotifPersianButtons { OK, OKCancel, RetryCancel, YesNoCancel, YesNo }
    public enum NotifPersianIcons { Error, Warning, Information, Question };
}
