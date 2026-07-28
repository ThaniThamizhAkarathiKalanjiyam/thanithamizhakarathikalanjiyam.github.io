using TTAK_BLZRV2.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTake.Entity
{
    public sealed class WMSFunctions
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static readonly WMSFunctions instance = new WMSFunctions();

        // Constructor is 'protected'

        private WMSFunctions()
        {

        }

        public static WMSFunctions Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            //if (instance == null)
            //{
            //    instance = new WMSFunctions();
            //}

            return instance;
        }

        public static string getNowTime(string format)
        {

            var NowTimeFormat = string.Empty;

            var trycatchUniqueNo = RandomST.Number;

            try
            {
                log.InfoFormat("{0}: 072228112023: Enter", trycatchUniqueNo);
                string UseUtcNow = ConfigurationManager.AppSettings["UseUtcNow"];

                if (UseUtcNow == "true")
                {
                    NowTimeFormat = DateTime.UtcNow.ToString(format);
                }
                else
                {
                    NowTimeFormat = DateTime.Now.ToString(format);
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("{0}: 072228112023: Error {1}", trycatchUniqueNo, ex.Message);

                if (ex.InnerException != null)
                {
                    log.ErrorFormat("{0}: 072228112023: InnerException {1}", trycatchUniqueNo, ex.InnerException.Message);
                }
                log.ErrorFormat("{0}: 072228112023: StackTrace {1}", trycatchUniqueNo, ex.ToString());
            }
            finally
            {
                log.InfoFormat("{0}: 072228112023: Exit", trycatchUniqueNo);
            }

            return NowTimeFormat;
        }

        public static QueueFileName getQueueFileName(string tableName, string folderName)
        {
            var TodayDate = string.Format("{0}{1}{2}",
                                 DateTime.Today.Year,
                                  String.Format("{0:00}", DateTime.Today.Month),
                                  String.Format("{0:00}", DateTime.Today.Day));

            QueueFileName objQueueFileName = new QueueFileName();
            try
            {
                log.Info("getQueueFileName: Enter");

                string dispatcherDataFolder = string.Empty;

                dispatcherDataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                   "App_Data", folderName);

                if (Directory.Exists(dispatcherDataFolder) == false)
                {
                    Directory.CreateDirectory(dispatcherDataFolder);
                }

                objQueueFileName.DbFileName = Path.Combine(dispatcherDataFolder, string.Format("{0}_{1}.Db.Dispatch",
                       tableName,
                       TodayDate
                       ));
                objQueueFileName.NavFileName = Path.Combine(dispatcherDataFolder, string.Format("{0}_{1}.Nav.Dispatch",
                      tableName,
                      TodayDate
                      ));
                objQueueFileName.NewFileName = Path.Combine(dispatcherDataFolder, string.Format("{0}_{1}.New",
                      tableName,
                      TodayDate
                      ));
                objQueueFileName.InsertedFileName = Path.Combine(dispatcherDataFolder, string.Format("{0}_{1}.Inserted",
                      tableName,
                      TodayDate
                      ));

                objQueueFileName.NormalFileName = Path.Combine(dispatcherDataFolder, string.Format("{0}_{1}.txt",
                      tableName,
                      TodayDate
                      ));
            }
            catch (Exception ex)
            {
                log.Error("getQueueFileName: Error" + ex.Message);

                if (ex.InnerException != null)
                {
                    log.Error("getQueueFileName: InnerException " + ex.InnerException.Message);
                }
                log.Error("getQueueFileName: StackTrace" + ex.StackTrace);
            }
            finally
            {
                log.Info("getQueueFileName: Exit");
            }

            return objQueueFileName;

        }
    }
}
