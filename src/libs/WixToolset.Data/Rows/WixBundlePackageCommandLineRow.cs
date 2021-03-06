// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data.Rows
{
    using System;

    /// <summary>
    /// Specialization of a row for the WixBundlePackageCommandLine table.
    /// </summary>
    public class WixBundlePackageCommandLineRow : Row
    {
        /// <summary>
        /// Creates a WixBundlePackageCommandLineRow row that does not belong to a table.
        /// </summary>
        /// <param name="sourceLineNumbers">Original source lines for this row.</param>
        /// <param name="tableDef">TableDefinition this WixBundlePackageCommandLineRow row belongs to and should get its column definitions from.</param>
        public WixBundlePackageCommandLineRow(SourceLineNumber sourceLineNumbers, TableDefinition tableDef) :
            base(sourceLineNumbers, tableDef)
        {
        }

        /// <summary>
        /// Creates an WixBundlePackageCommandLineRow row that belongs to a table.
        /// </summary>
        /// <param name="sourceLineNumbers">Original source lines for this row.</param>
        /// <param name="table">Table this WixBundlePackageCommandLineRow row belongs to and should get its column definitions from.</param>
        public WixBundlePackageCommandLineRow(SourceLineNumber sourceLineNumbers, Table table)
            : base(sourceLineNumbers, table)
        {
        }

        /// <summary>
        /// Gets or sets the package identifier.
        /// </summary>
        /// <value>The package identifier.</value>
        public string ChainPackageId
        {
            get { return (string)this.Fields[0].Data; }
            set { this.Fields[0].Data = value; }
        }

        /// <summary>
        /// Gets or sets the command-line argument for installation.
        /// </summary>
        /// <value>The command-line argument.</value>
        public string InstallArgument
        {
            get { return (string)this.Fields[1].Data; }
            set { this.Fields[1].Data = value; }
        }

        /// <summary>
        /// Gets or sets the command-line argument for uninstallation.
        /// </summary>
        /// <value>The command-line argument.</value>
        public string UninstallArgument
        {
            get { return (string)this.Fields[2].Data; }
            set { this.Fields[2].Data = value; }
        }

        /// <summary>
        /// Gets or sets the command-line argument for repair.
        /// </summary>
        /// <value>The command-line argument.</value>
        public string RepairArgument
        {
            get { return (string)this.Fields[3].Data; }
            set { this.Fields[3].Data = value; }
        }

        /// <summary>
        /// Gets or sets the condition.
        /// </summary>
        /// <value>The condition.</value>
        public string Condition
        {
            get { return (string)this.Fields[4].Data; }
            set { this.Fields[4].Data = value; }
        }
    }
}
