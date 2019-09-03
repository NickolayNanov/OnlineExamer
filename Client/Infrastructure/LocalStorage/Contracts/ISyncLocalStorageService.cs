﻿namespace OnlineExamer.Client.Infrastructure.LocalStorage.Contracts
{
    using System;

    public interface ISyncLocalStorageService
    {
        void Clear();

        T GetItem<T>(string key);

        string Key(int index);

        int Length();

        void RemoveItem(string key);

        void SetItem(string key, object data);

        event EventHandler<ChangingEventArgs> Changing;
        event EventHandler<ChangedEventArgs> Changed;
    }
}
