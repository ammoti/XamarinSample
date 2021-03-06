﻿using Acr.UserDialogs;
using Medyasoft.HealthCare.Contracts.Services.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Medyasoft.HealthCare.Services.General
{
    public class DialogService : IDialogService
    {
        public Task ShowDialog(string message, string title, string buttonLabel)
        {
            return UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
        }

        public void ShowToast(string message)
        {
            UserDialogs.Instance.Toast(message);
        }
    }
}
