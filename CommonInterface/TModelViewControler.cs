using CommonInterface.Commands;
//#define ASYNC_LATENCY_TEST
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommonInterface
{
    public abstract class TModelViewControler<TUser, TModel> : ITModelViewControler<TUser, TModel>, INotifyPropertyChanged
    {
        #region Properties

        private readonly object _locker = new object();
        private List<TModel> _lastUpdate;

        public List<TModel> LastUpdate
        {
            get
            {
                lock (this._locker)
                    return this._lastUpdate;
            }
            private set
            {
                lock (this._locker)
                    this._lastUpdate = value;
                this.RaisePropertyChanged("LastUpdate");
            }
        }

        protected Func<TUser, bool> UserLoginFunc { get; set; }
        protected Func<TModel, bool> AddFunc { get; set; }
        protected Func<TModel, bool> ModifyFunc { get; set; }
        protected Func<List<TModel>> RefreshAction { get; set; }

        public ICommand UserLoginCommand { get; private set; }
        public ICommand AddCommand { get; private set; }
        public ICommand ModifyCommand { get; private set; }
        public ICommand RefreshCommand { get; private set; }

        #endregion

        #region Events

        public event EventHandler<List<TModel>> ModelUpdated;
        public event EventHandler NotSaved;
        public event EventHandler Saved;
        public event EventHandler LoginAccepted;
        public event EventHandler LoginRejected;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaiseUserLoginEvent(bool successful_)
        {
            var handler = successful_ ? this.LoginAccepted : this.LoginRejected;
            if (handler != null)
                handler(this, EventArgs.Empty);
            if (successful_)
                this.Refresh();
        }

        protected void RaiseSavedEvent(bool successful_)
        {
            var handler = successful_ ? this.Saved : this.NotSaved;
            if (handler != null)
                handler(this, EventArgs.Empty);
            if (successful_)
                this.Refresh();
        }

        protected void RaiseModelUpdatedEvent(List<TModel> model_)
        {
            var handler = this.ModelUpdated;
            if (handler != null)
                handler(this, model_);
        }

        private void RaisePropertyChanged(string propertyName_)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName_));
        }
        #endregion

        #region Initialization

        protected TModelViewControler(Func<TUser, bool> loginFunc_, Func<TModel, bool> addFunc_, Func<TModel, bool> modifyFunc_,
            Func<List<TModel>> refreshAction_)
        {
            this.UserLoginFunc = loginFunc_;
            this.AddFunc = addFunc_;
            this.ModifyFunc = modifyFunc_;
            this.RefreshAction = refreshAction_;

            this.UserLoginCommand = new ParameteredCommand<TUser>(new Action<TUser>(this.UserLogin));
            this.AddCommand = new ParameteredCommand<TModel>(new Action<TModel>(this.Add));
            this.ModifyCommand = new ParameteredCommand<TModel>(new Action<TModel>(this.Update));
            this.RefreshCommand = new ParameterlessCommand(new Action(this.Refresh));
        }
        #endregion

        public async void UserLogin(TUser userDetails_)
        {
            await Task.Run(() =>
            {
#if ASYNC_LATENCY_TEST
                    System.Threading.Thread.Sleep(10000);
#endif
                this.RaiseUserLoginEvent(this.UserLoginFunc(userDetails_));
            });
        }

        public async void Add(TModel data_)
        {
            await Task.Run(() =>
                {
#if ASYNC_LATENCY_TEST
                    System.Threading.Thread.Sleep(10000);
#endif
                    this.RaiseSavedEvent(this.AddFunc(data_));
                });
        }

        public async void Update(TModel data_)
        {
            await Task.Run(() =>
                {
#if ASYNC_LATENCY_TEST
                    System.Threading.Thread.Sleep(10000);
#endif
                    this.RaiseSavedEvent(this.ModifyFunc(data_));
                });
        }

        public async void Refresh()
        {
            await Task.Run(() =>
            {
#if ASYNC_LATENCY_TEST
                    System.Threading.Thread.Sleep(10000);
#endif
                this.RaiseModelUpdatedEvent(this.LastUpdate = this.RefreshAction());
            });
        }
    }
}