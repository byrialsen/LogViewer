﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CheckableFilesLocation.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2014 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace LogViewer.Models
{
    using Catel.Data;

    public class CheckableFilesLocation : ModelBase
    {
        public FilesLocation Location { get; set; }
        public bool IsChecked { get; set; }
    }
}