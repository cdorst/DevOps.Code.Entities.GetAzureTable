// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage.Table;
using System.Threading.Tasks;
using static Azure.Storage.Table.GetAzureTable.AzureTableGetter;

namespace DevOps.Code.Entities.GetAzureTable
{
    /// <summary>Function returns an Azure CloudTable reference for a table named entities</summary>
    public static class AzureTableGetter
    {
        private const string entities = nameof(entities);

        /// <summary>Returns an Azure CloudTable reference for a table named "entities" in the storage account for the connection string stored in the environment</summary>
        public static async Task<CloudTable> GetTable() => await AzureTable(entities);
    }
}
