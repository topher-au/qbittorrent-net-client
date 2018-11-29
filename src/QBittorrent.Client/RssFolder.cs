﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace QBittorrent.Client
{
    /// <summary>
    /// Represents an RSS folder.
    /// </summary>
    /// <seealso cref="QBittorrent.Client.RssItem" />
    [DebuggerDisplay("Folder {Name} with {Items.Count} items")]
    public class RssFolder : RssItem
    {
        public RssFolder() : this(null)
        {
        }

        public RssFolder(IEnumerable<RssItem> items)
        {
            Items = new List<RssItem>(items ?? Enumerable.Empty<RssItem>());
        }

        public IList<RssItem> Items { get; }

        public IEnumerable<RssFolder> Folders => Items?.OfType<RssFolder>();

        public IEnumerable<RssItem> Feeds => Items?.OfType<RssFeed>();
    }
}
