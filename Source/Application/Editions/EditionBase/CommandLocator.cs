﻿using pdfforge.PDFCreator.Core.Services;
using pdfforge.PDFCreator.Core.Services.Macros;
using SimpleInjector;
using System.Windows.Input;

namespace pdfforge.PDFCreator.Editions.EditionBase
{
    public class CommandLocator : ICommandLocator
    {
        private Container _container;

        public CommandLocator(Container container)
        {
            _container = container;
        }

        public ICommand GetCommand<T>() where T : class, ICommand
        {
            ICommand instance = _container.GetInstance<T>();
            return instance;
        }

        public IMacroCommand GetMacroCommand()
        {
            return GetCommand<MacroCommand>() as MacroCommand;
        }

        public ICommand GetInitializedCommand<TCommand, TParameter>(TParameter parameter) where TCommand : class, IInitializedCommand<TParameter>
        {
            if (parameter == null)
                return null;
            var instance = _container.GetInstance<TCommand>();
            instance?.Init(parameter);
            return instance;
        }
    }
}
