﻿using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public static partial class Launcher
    {
        public static Task<bool> CanOpenAsync(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri))
            {
                throw new ArgumentNullException(nameof(uri), $"Uri cannot be empty.");
            }
            return PlatformCanOpenAsync(new Uri(uri));
        }

        public static Task<bool> CanOpenAsync(Uri uri)
        {
            return uri != null ? PlatformCanOpenAsync(uri)
                : throw new ArgumentNullException(nameof(uri), $"Uri cannot be empty.");
        }

        public static Task OpenAsync(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri))
            {
                throw new ArgumentNullException(nameof(uri), $"Uri cannot be empty.");
            }
            return PlatformOpenAsync(new Uri(uri));
        }

        public static Task OpenAsync(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri), $"Uri cannot be empty.");
            }
            return PlatformOpenAsync(uri);
        }
    }
}
