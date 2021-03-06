﻿namespace QBittorrent.Client
{
    /// <summary>
    /// The base class for add torrent requests.
    /// </summary>
    public abstract class AddTorrentRequestBase
    {
        /// <summary>
        /// Download folder
        /// </summary>
        public string DownloadFolder { get; set; }

        /// <summary>
        /// Cookie sent to download the .torrent file
        /// </summary>
        public string Cookie { get; set; }

        /// <summary>
        /// Category for the torrent
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Skip hash checking.
        /// </summary>
        public bool SkipHashChecking { get; set; }

        /// <summary>
        /// Add torrents in the paused state.
        /// </summary>
        public bool Paused { get; set; }

        /// <summary>
        /// Create the root folder.
        /// </summary>
        public bool? CreateRootFolder { get; set; }

        /// <summary>
        /// Rename torrent
        /// </summary>
        public string Rename { get; set; }

        /// <summary>
        /// Set torrent upload speed limit
        /// </summary>
        public int? UploadLimit { get; set; }

        /// <summary>
        /// Set torrent download speed limit
        /// </summary>
        public int? DownloadLimit { get; set; }

        /// <summary>
        /// Enable sequential download
        /// </summary>
        public bool SequentialDownload { get; set; }

        /// <summary>
        /// Prioritize download of first and last pieces
        /// </summary>
        public bool FirstLastPiecePrioritized { get; set; }
        
    }
}
