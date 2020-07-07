namespace CardPrinterFacade
{
    using System.Diagnostics;
    public class EventLogger
    {
        #region Fields
        /// <summary>
        /// Field : Log Source
        /// </summary>
        string source = "CardPrinterLibrary";
        EventLog systemEventLog = new EventLog("System");
        #endregion

        #region Methods
        /// <summary>
        /// Log event
        /// </summary>
        ///<param name="pEvent"></param>
        public void LogEvent(string pEvent)
        {
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, "System");
            }
            systemEventLog.Source = source;
            systemEventLog.WriteEntry(pEvent, EventLogEntryType.SuccessAudit, 150);
        }


        /// <summary>
        /// Log Error event
        /// </summary>
        ///<param name="pError"></param>
        public void LogError(string pError)
        {
            //Update to throw an exception --- Stanard error handling message
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, "System");
            }
            systemEventLog.Source = source;
            systemEventLog.WriteEntry(pError, EventLogEntryType.Error, 150);
        }

        /// <summary>
        ///Write Event
        /// </summary>
        ///<param name="pEventMessage"></param>
        private void WriteEventLogEntry(string pEventMessage)
        {
            // Create an instance of EventLog
            System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog();

            // Check if the event source exists. If not create it.
            if (!System.Diagnostics.EventLog.SourceExists(source))
            {
                System.Diagnostics.EventLog.CreateEventSource(source, "Application");
            }

            eventLog.Source = source;
            int eventID = 8;
            eventLog.WriteEntry(pEventMessage, System.Diagnostics.EventLogEntryType.Information, eventID);
            eventLog.Close();
        }
        #endregion

    }
}
