﻿// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Devices.Sensors;
using System.Collections.ObjectModel;

namespace DeviceStatus
{
    /// <summary>
    /// Provides device capability information for design time.
    /// </summary>
    public class FakeCapabilityInformation : CapabilityInformation
    {
        /// <summary>
        /// Returns arbitrary made up data.
        /// </summary>
        public override void RefreshData()
        {
            IsGyroSupported = true;
            IsAccelerometerSupported = true;
            IsCompassSupported = true;
            IsMotionSupported = true;

            SupportedResolutions = new ObservableCollection<string>(new[] { "1x1", "10x10", "100x100" });
        }
    }
}