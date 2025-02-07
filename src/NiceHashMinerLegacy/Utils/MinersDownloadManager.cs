﻿namespace NiceHashMiner.Utils
{
    public static class MinersDownloadManager
    {
        public static readonly DownloadSetup StandardDlSetup = new DownloadSetup(
            "https://github.com/nicehash/NiceHashMinerLegacy/releases/download/1.9.0.23/bin_1_9_0_23.zip",
            "bins.zip",
            "bin");

        public static readonly DownloadSetup ThirdPartyDlSetup = new DownloadSetup(
            "https://github.com/nicehash/NiceHashMinerLegacy/releases/download/1.9.0.23/bin_3rdparty_1_9_0_23.zip",
            "bins_3rdparty.zip",
            "bin_3rdparty");
    }
}
