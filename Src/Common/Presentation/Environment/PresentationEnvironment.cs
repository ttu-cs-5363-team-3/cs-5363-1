﻿using Ttu.Domain;

namespace Ttu.Presentation
{
    public class PresentationEnvironment
    {

        public static PresentationEnvironment Singleton = new PresentationEnvironment();

        # region Constructors

        private PresentationEnvironment()
        {
            Map = new ThreadSafeMap<string, IPresenterFactory>();
        }

        # endregion

        # region Properties

        private ThreadSafeMap<string, IPresenterFactory> Map { get; set; }

        # endregion

        # region Public Methods

        public IPresenterFactory ValidatePresenterFactory(string sessionId)
        {
            // guard clause - session does not exist
            IPresenterFactory presenterFactory = Map[sessionId];
            if (presenterFactory == null)
            {
                throw new BusinessException("Invalid session id.");
            }

            return presenterFactory;
        }

        # endregion

    }
}
