using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CommonInterface
{
    public interface ITModelViewControler<TUser, TModel> : INotifyPropertyChanged
    {
        event EventHandler<List<TModel>> ModelUpdated;
        event EventHandler NotSaved;
        event EventHandler Saved;
        event EventHandler LoginAccepted;
        event EventHandler LoginRejected;
        List<TModel> LastUpdate { get; }
        void UserLogin(TUser userDetails_);
        void Add(TModel data_);
        void Update(TModel data_);
        void Refresh();
    }
}