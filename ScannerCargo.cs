﻿using System;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the ScannerCargo datatype.
    /// </summary>
    // CargoScanner dude, CargoScanner!
    public class ScannerCargo : LavishScriptObject
    {
        public ScannerCargo(LavishScriptObject Copy) : base(Copy)
        {
        }

        /// <summary>
        /// If ClearPreviousResults is false, then new results are appended to previous. Results will be available in Entity.GetCargoScannerResults()
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="clearPreviousResults"></param>
        /// <returns></returns>
        public bool StartScan(Int64 entityId, bool clearPreviousResults)
        {
            return ExecuteMethod("StartScan", entityId.ToString(), clearPreviousResults.ToString());
        }
    }
}
