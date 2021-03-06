﻿using pdfforge.PDFCreator.Core.Controller;
using pdfforge.PDFCreator.UI.Presentation.Customization;
using pdfforge.PDFCreator.UI.Presentation.ServiceLocator;
using System.Windows.Controls;

namespace pdfforge.PDFCreator.UI.Presentation.UserControls
{
    public partial class ApplicationLogoControl : UserControl
    {
        public ApplicationLogoControl()
        {
            ViewCustomization viewCustomization = null;
            if (RestrictedServiceLocator.IsLocationProviderSet)
            {
                DataContext = RestrictedServiceLocator.Current.GetInstance<ApplicationNameProvider>();
                viewCustomization = RestrictedServiceLocator.Current.GetInstance<ViewCustomization>();
            }

            InitializeComponent();

            if (viewCustomization?.ApplyCustomization == true)
            {
                CustomEditionText.Text = viewCustomization.MainWindowText;
            }
        }
    }
}
