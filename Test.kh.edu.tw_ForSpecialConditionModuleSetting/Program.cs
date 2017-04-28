using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FISCA;
using FISCA.Presentation;
using Framework;
using JHSchool;

namespace Test.kh.edu.tw_ForSpecialConditionModuleSetting
{

    public static class Program
    {
        [MainMethod()]
        static public void Main()
        {
            // 2017/4/28 穎驊更新，因應高雄小組會議 [02-05][01] 非明細獎懲紀錄問題 項目， 局端決議 將各校 匯入獎勵懲戒統計 拿掉，避免使用者誤使用
            // 在此將其改為不可以見。(已在JHSchool.Behavior 專案修改)
            // 另外由於局端要求，希望在test.kh.edu.tw 能暫時保留此選項，供它們 2017/9 教育訓練說明用，在此另外做了一個專門掛給test.kh.edu.tw的模組，
            // 會將此功能開啟，
            // 日後有任何test.kh.edu.tw  想要與外部高雄國中有不同模組開放差異，皆在此專案管理。

            //匯入
            RibbonBarButton rbItemImport = Student.Instance.RibbonBarItems["資料統計"]["匯入"];

            rbItemImport["學務相關匯入"]["匯入獎勵懲戒統計"].Visible = true;
                
        }        
    }

}
