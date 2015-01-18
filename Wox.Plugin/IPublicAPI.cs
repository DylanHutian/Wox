﻿using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Wox.Plugin
{
    public interface IPublicAPI
    {
        /// <summary>
        /// Push result to query window
        /// </summary>
        /// <param name="query"></param>
        /// <param name="plugin"></param>
        /// <param name="results"></param>
        /// <param name="clearBeforeInsert"></param>
        void PushResults(Query query,PluginMetadata plugin, List<Result> results,bool clearBeforeInsert = false);

        bool ShellRun(string cmd, bool runAsAdministrator = false);

        void ChangeQuery(string query, bool requery = false);

        void CloseApp();

        void HideApp();

        void ShowApp();

        void ShowMsg(string title, string subTitle, string iconPath);

        void OpenSettingDialog();

        void StartLoadingBar();

        void StopLoadingBar();

        void InstallPlugin(string path);

        void ReloadPlugins();

        string GetTranslation(string key);

        List<PluginPair> GetAllPlugins();

        event WoxKeyDownEventHandler BackKeyDownEvent;

        event WoxGlobalKeyboardEventHandler GlobalKeyboardEvent;

        /// <summary>
        /// fired after wox execute a query
        /// </summary>
        event AfterWoxQueryEventHandler AfterWoxQueryEvent;

        /// <summary>
        /// fired before wox start to execute a query
        /// </summary>
        event AfterWoxQueryEventHandler BeforeWoxQueryEvent;
    }
}
