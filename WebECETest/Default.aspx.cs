using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dtec;
using System.Globalization;
using System.Xml;

namespace WebECETest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click()
        {
            Dtec.ECEClass ece = new Dtec.ECEClass();
            
            
            ECEClass.Sender s = new ECEClass.Sender();
            string name = s.Name;
            
            s.Organization = "سازمان عباس";
            ECEClass.Origin or = new ECEClass.Origin();
            or.ContentType = "application/msword";
            or.Description = "";
            or.encodedBase64String = "2KfYsdis2KfYuSDYr9mH2YbYr9mHIDog2qnYsduM2YUg2LnYsdioIC0g2LHYptuM2LMg2Ygg2qnYp9ix2LTZhtin2LMg2KfYsdi02K8g2YHYsdin2KjYsduMINiv2KfYr9mHINmH2KcgKNiv2LHZhdin2YYg2KfZhNio2LHYsikNCtin2LHYrNin2Lkg2q/Zitix2YbYr9qv2KfZhiA6IA0KCdin2YTZh9in2YUg2LnYstuM2LLZvtmI2LHbjNin2YYgLSDaqdin2LHYtNmG2KfYsyDZgdix2KfYqNix24wg2K/Yp9iv2Ycg2YfYpyAxKCDYr9ix2YXYp9mGINin2YTYqNix2LIgKQ0KCdmE24zZhNinINmE2KfbjNmCINit2YLbjNmC24wgLSDaqdin2LHYtNmG2KfYsyDZgdix2KfYqNix24wg2K/Yp9iv2Ycg2YfYpyAo2K/YsdmF2KfZhiDYp9mE2KjYsdiyKQ0K2KrYp9ix2YrYriDYp9ix2KzYp9i5IDogMTM5Mi8xMC8xNw0K2KfYsdis2K3ZitiqIDog2LnYp9iv24wNCtm+2Yog2YbZiNi02KogOiDYrNmH2Kog2KfYt9mE2KfYuQ0KDQoqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqDQrYp9ix2KzYp9i5INiv2YfZhtiv2YcgOiDZhdix24zZhSDYudio2K/bjCAtINix2KbbjNizINqv2LHZiNmHINiz24zYs9iq2YXZh9in24wg2LPYqtin2K/bjCDYr9mB2KrYsSDYsdin2YfYqNix24wg2LPbjNiz2KrZhSDZh9inDQrYp9ix2KzYp9i5INqv2YrYsdmG2K/ar9in2YYgOiANCgnZhdit2YXYr9ix2LbYpyDYsdmB24zYuSDZvtmI2LEgLSDaqdin2LHYtNmG2KfYsyDYqtit2YTbjNmE2q/YsSDYs9uM2LPYqtmFCdiq2KfYsdmK2K4g2YXYtNin2YfYr9mHIDogMTM5Mi8xMC8xNg0K2KrYp9ix2YrYriDYp9ix2KzYp9i5IDogMTM5Mi8xMC8xNg0K2KfYsdis2K3ZitiqIDog2LnYp9iv24wNCtmG2YjYuSDYp9ix2KzYp9i5IDog2KjYsdin24wg2KfZgtiv2KfZhQ0KDQoqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqDQrYp9ix2KzYp9i5INiv2YfZhtiv2YcgOiDZgdin2LfZhdmHINi52KjYp9iz24wgLSDZhdiz2KbZiNmEINiv2YHYqtixINix2KfZh9io2LHbjCDYs9uM2LPYqtmF2YfYpw0K2KfYsdis2KfYuSDar9mK2LHZhtiv2q/Yp9mGIDogDQoJ2YXYsduM2YUg2LnYqNiv24wgLSDYsdim24zYsyDar9ix2YjZhyDYs9uM2LPYqtmF2YfYp9uMINiz2KrYp9iv24wg2K/Zgdiq2LEg2LHYp9mH2KjYsduMINiz24zYs9iq2YUg2YfYpwnYqtin2LHZitiuINmF2LTYp9mH2K/ZhyA6IDEzOTIvMTAvMTYNCtiq2KfYsdmK2K4g2KfYsdis2KfYuSA6IDEzOTIvMTAvMTYNCtin2LHYrNit2YrYqiA6INi52KfYr9uMDQoNCioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioNCtin2LHYrNin2Lkg2K/Zh9mG2K/ZhyA6INmF2KzbjNivINmF2YfYr9uMINmF24zYsdiy2Kcg2qnYp9i02KfZhtuMIC0g2YXYqti12K/bjCDYp9mF2YjYsSDYr9mB2KrYsduMIDENCtin2LHYrNin2Lkg2q/Zitix2YbYr9qv2KfZhiA6IA0KCdmH2Ybar9in2YXZhyDaqdin2qnZiNim24wgLSDYp9m+2LHYp9iq2YjYsSDYr9io24zYsdiu2KfZhtmHINmF2LHaqdiy24wgMTEJ2KrYp9ix2YrYriDZhdi02KfZh9iv2YcgOiAxMzkyLzEwLzE3DQrYqtin2LHZitiuINin2LHYrNin2LkgOiAxMzkyLzEwLzE2DQrYp9ix2KzYrdmK2KogOiDYudin2K/bjA0K2YbZiNi5INin2LHYrNin2LkgOiDYqNix2KfbjCDYp9mC2K/Yp9mFDQrZvtmKINmG2YjYtNiqIDog2K7Yp9mG2YUg2qnYp9qp2YjbjNuMDQrYqNin2LPZhNin2YUNCtmE2LfZgdin2Ysg2K/YsSDYotix2LTbjNmIINmG2q/Zh9iv2KfYsduMINmB2LHZhdin2KbbjNivIC4gDQoNCioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioNCtin2LHYrNin2Lkg2K/Zh9mG2K/ZhyA6INmF2KzbjNivINmF2YfYr9uMINmF24zYsdiy2Kcg2qnYp9i02KfZhtuMIC0g2YXYqti12K/bjCDYp9mF2YjYsSDYr9mB2KrYsduMIDENCtin2LHYrNin2Lkg2q/Zitix2YbYr9qv2KfZhiA6IA0KCdmB2KfYt9mF2Ycg2LnYqNin2LPbjCAtINmF2LPYptmI2YQg2K/Zgdiq2LEg2LHYp9mH2KjYsduMINiz24zYs9iq2YXZh9inCdiq2KfYsdmK2K4g2YXYtNin2YfYr9mHIDogMTM5Mi8xMC8xNg0K2KrYp9ix2YrYriDYp9ix2KzYp9i5IDogMTM5Mi8xMC8xNg0K2KfYsdis2K3ZitiqIDog2LnYp9iv24wNCtmG2YjYuSDYp9ix2KzYp9i5IDog2KjYsdin24wg2KfZgtiv2KfZhQ0K2b7ZiiDZhtmI2LTYqiA6INiz2LHaqdin2LEg2K7Yp9mG2YUg2LnYqNin2LPbjCANCtio2KfYs9mE2KfZhSANCtiu2YjYp9mH2LTZhdmG2K8g2KfYs9iqINiv2LPYqtmI2LEg2YHYsdmF2KfYptuM2K8g2YbYp9mFINqp2KfYsdio2LHbjCDZhdi02KfYsdin2YTbjNmHINiv2LEg2LPbjNiz2KrZhSDYp9iq2YjZhdin2LPbjNmI2YYg2KfYudmF2KfZhCDar9ix2K/Yrw0KDQoqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqDQrYp9ix2KzYp9i5INiv2YfZhtiv2YcgOiDZhdit2YXYr9i52YTbjCDZhti42LHbjCAtINmF2LnYp9mI2YYg2KfYs9mG2KfYryDZiCDYr9io24zYsdiu2KfZhtmHINin2YXZiNixINin2K/Yp9ix24wNCtin2LHYrNin2Lkg2q/Zitix2YbYr9qv2KfZhiA6IA0KCdmF2KzbjNivINmF2YfYr9uMINmF24zYsdiy2Kcg2qnYp9i02KfZhtuMIC0g2YXYqti12K/bjCDYp9mF2YjYsSDYr9mB2KrYsduMIDEJ2KrYp9ix2YrYriDZhdi02KfZh9iv2YcgOiAxMzkyLzEwLzE2DQrYqtin2LHZitiuINin2LHYrNin2LkgOiAxMzkyLzEwLzE2DQrYp9ix2KzYrdmK2KogOiDYudin2K/bjA0K2YbZiNi5INin2LHYrNin2LkgOiDYqNix2KfbjCDYp9mC2K/Yp9mFDQrZvtmKINmG2YjYtNiqIDog2KjYs9mF2Ycg2KrYudin2YTbjCDYqNinINiz2YTYp9mFINmE2LfZgdinINin2YLYr9in2YUg2KjYsSDYp9iz2KfYsyDYttmI2KfYqNi3DQoNCioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioNCtin2LHYrNin2Lkg2K/Zh9mG2K/ZhyA6INi32KfZh9ix2Ycg2KfYrdmF2K/bjCAtINqp2KfYsdi02YbYp9izINmF2LPYptmI2YQg2KfYr9in2LHZhyDaqdmEINin2YXZiNixINin2K/Yp9ix24wNCtin2LHYrNin2Lkg2q/Zitix2YbYr9qv2KfZhiA6IA0KCdmF2K3Zhdiv2LnZhNuMINmG2LjYsduMIC0g2YXYudin2YjZhiDYp9iz2YbYp9ivINmIINiv2KjbjNix2K7Yp9mG2Ycg2KfZhdmI2LEg2KfYr9in2LHbjAnYqtin2LHZitiuINmF2LTYp9mH2K/ZhyA6IDEzOTIvMTAvMTYNCtiq2KfYsdmK2K4g2KfYsdis2KfYuSA6IDEzOTIvMTAvMTYNCtin2LHYrNit2YrYqiA6INi52KfYr9uMDQoNCioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioNCtin2LHYrNin2Lkg2K/Zh9mG2K/ZhyA6INiv2KjbjNix2K7Yp9mG2Ycg2KfYs9iq2KfZhiAxIC0g2K/YqNuM2LHYrtin2YbZhyDYp9iz2KrYp9mGIDENCtin2LHYrNin2Lkg2q/Zitix2YbYr9qv2KfZhiA6IA0KCdi32KfZh9ix2Ycg2KfYrdmF2K/bjCAtINqp2KfYsdi02YbYp9izINmF2LPYptmI2YQg2KfYr9in2LHZhyDaqdmEINin2YXZiNixINin2K/Yp9ix24wJ2KrYp9ix2YrYriDZhdi02KfZh9iv2YcgOiAxMzkyLzEwLzE2DQrYqtin2LHZitiuINin2LHYrNin2LkgOiAxMzkyLzEwLzE2DQrYp9ix2KzYrdmK2KogOiDYudin2K/bjA0KDQoqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqDQrYp9ix2KzYp9i5INiv2YfZhtiv2YcgOiDZhdix24zZhSDYtdmB24wg2K7Yp9mG24wgLSDZhdiz2KbZiNmEINiv2KjbjNix2K7Yp9mG2Ycg2YXYsdqp2LLbjCAo2K/YsdmF2KfZhiDYp9mE2KjYsdiyKQ0K2KfYsdis2KfYuSDar9mK2LHZhtiv2q/Yp9mGIDogDQoJ2K/YqNuM2LHYrtin2YbZhyDYp9iz2KrYp9mGIDEgLSDYr9io24zYsdiu2KfZhtmHINin2LPYqtin2YYgMQnYqtin2LHZitiuINmF2LTYp9mH2K/ZhyA6IDEzOTIvMTAvMTYNCtiq2KfYsdmK2K4g2KfYsdis2KfYuSA6IDEzOTIvMTAvMTYNCtin2LHYrNit2YrYqiA6INi52KfYr9uMDQrZhtmI2Lkg2KfYsdis2KfYuSA6INio2LHYp9uMINin2YLYr9in2YUNCg0KKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKg0K2KfYsdis2KfYuSDYr9mH2YbYr9mHIDog2YbYp9i12LEg2YTbjNmI2KfYsduMIC0g2YXYudin2YjZhiDYp9iv2KfYsduMINmIINmF2KfZhNuMINiv2LHZhdin2YYg2KfYs9iq2KfZhiDYp9mE2KjYsdiyDQrYp9ix2KzYp9i5INqv2YrYsdmG2K/ar9in2YYgOiANCgnaqdix24zZhSDYudix2KggLSDYsdim24zYsyDZiCDaqdin2LHYtNmG2KfYsyDYp9ix2LTYryDZgdix2KfYqNix24wg2K/Yp9iv2Ycg2YfYpyAo2K/YsdmF2KfZhiDYp9mE2KjYsdiyKQnYqtin2LHZitiuINmF2LTYp9mH2K/ZhyA6IDEzOTIvMTAvMTcNCgnZhdix24zZhSDYtdmB24wg2K7Yp9mG24wgLSDZhdiz2KbZiNmEINiv2KjbjNix2K7Yp9mG2Ycg2YXYsdqp2LLbjCAo2K/YsdmF2KfZhiDYp9mE2KjYsdiyKQnYqtin2LHZitiuINmF2LTYp9mH2K/ZhyA6IDEzOTIvMTAvMTYNCtiq2KfYsdmK2K4g2KfYsdis2KfYuSA6IDEzOTIvMTAvMTYNCtmG2YjYuSDYp9ix2KzYp9i5IDog2KjYsdin24wg2KfZgtiv2KfZhQ0KDQoqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqDQrYp9ix2KzYp9i5INiv2YfZhtiv2YcgOiDYp9mB2LTbjNmGINio2YfYp9iv2LHbjCAtINiz2LHZvtix2LPYqiDYp9mF2YjYsSDYp9iv2KfYsduMINmIINm+2LTYqtuM2KjYp9mG24wgKNiv2LHZhdin2YYg2KfZhNio2LHYsikNCtin2LHYrNin2Lkg2q/Zitix2YbYr9qv2KfZhiA6IA0KCdmG2KfYtdixINmE24zZiNin2LHbjCAtINmF2LnYp9mI2YYg2KfYr9in2LHbjCDZiCDZhdin2YTbjCDYr9ix2YXYp9mGINin2LPYqtin2YYg2KfZhNio2LHYsgnYqtin2LHZitiuINmF2LTYp9mH2K/ZhyA6IDEzOTIvMTAvMTYNCtiq2KfYsdmK2K4g2KfYsdis2KfYuSA6IDEzOTIvMTAvMTYNCtin2LHYrNit2YrYqiA6INi52KfYr9uMDQrZhtmI2Lkg2KfYsdis2KfYuSA6INio2LHYp9uMINiq2KfbjNuM2K8NCg0KKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKg0K2KfYsdis2KfYuSDYr9mH2YbYr9mHIDog2qnYqNix24wg2K3Zgtqv2Ygg2b7Yp9iz2qnbjNin2KjbjCAtINqp2KfYsdi02YbYp9izINin2LHYtNivINin2YXZiNixINin2K/Yp9ix24wgKNiv2LHZhdin2YYg2KfZhNio2LHYsikNCtin2LHYrNin2Lkg2q/Zitix2YbYr9qv2KfZhiA6IA0KCdin2YHYtNuM2YYg2KjZh9in2K/YsduMIC0g2LPYsdm+2LHYs9iqINin2YXZiNixINin2K/Yp9ix24wg2Ygg2b7YtNiq24zYqNin2YbbjCAo2K/YsdmF2KfZhiDYp9mE2KjYsdiyKQnYqtin2LHZitiuINmF2LTYp9mH2K/ZhyA6IDEzOTIvMTAvMTYNCtiq2KfYsdmK2K4g2KfYsdis2KfYuSA6IDEzOTIvMTAvMTYNCtin2LHYrNit2YrYqiA6INi52KfYr9uMDQrZhtmI2Lkg2KfYsdis2KfYuSA6INio2LHYp9uMINiq2KfbjNuM2K8NCtm+2Yog2YbZiNi02KogOiDYrNmH2Kog2KfYs9iq2K3Yttin2LEg2Ygg2K/Ys9iq2YjYsSDZhdmC2KrYttuMDQoNCioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioNCtin2LHYrNin2Lkg2K/Zh9mG2K/ZhyA6INix2LbYpyDZvtin2LHYs9in2YHYsSAtINqp2KfYsdi02YbYp9izINin2YXZiNixINin2K/Yp9ix24wgMSAo2K/YsdmF2KfZhiDYp9mE2KjYsdiyKQ0K2KfYsdis2KfYuSDar9mK2LHZhtiv2q/Yp9mGIDogDQoJ2qnYqNix24wg2K3Zgtqv2Ygg2b7Yp9iz2qnbjNin2KjbjCAtINqp2KfYsdi02YbYp9izINin2LHYtNivINin2YXZiNixINin2K/Yp9ix24wgKNiv2LHZhdin2YYg2KfZhNio2LHYsikJ2KrYp9ix2YrYriDZhdi02KfZh9iv2YcgOiAxMzkyLzEwLzE2DQrYqtin2LHZitiuINin2LHYrNin2LkgOiAxMzkyLzEwLzE1DQrYp9ix2KzYrdmK2KogOiDYudin2K/bjA0K2YbZiNi5INin2LHYrNin2LkgOiDYqNix2KfbjCDYqtin24zbjNivDQoNCioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioqKioNCg==";
            or.Extension = "doc";
            or.Any = "";
            ECEClass.Origins ors = new ECEClass.Origins();
            ors.addOrigin(or);
            ors.getOrigins();

        }



        ECEClass.OtherReceiver otherReceiver = null;
        protected void btnCreateECE_Click(object sender, EventArgs e)
        {
            ECEClass ece = new ECEClass();
            ece.initializeDefaultECEXml();
         
            ECEClass.Subject subject = new ECEClass.Subject();
            subject._Subject = txtSubject.Text;

            ECEClass.LetterNo letterno = new ECEClass.LetterNo();
            letterno._LetterNo = txtLetterNo.Text;

            ECEClass.LetterDateTime letterDateTime = new ECEClass.LetterDateTime();
            //PersianCalendar persianCalendar = new PersianCalendar ();
            ////suppose format of farsi date is like 1392/11/16
            //string[] farsidate=txtLetterDate.Text.Split(new char[]{'/'});
            //DateTime dateTime = persianCalendar.ToDateTime (int.Parse(farsidate[0]),int.Parse(farsidate[1]),int.Parse(farsidate[2]),0,0,0,0);
            //letterDateTime._LetterDateTime = dateTime.ToString();
            letterDateTime._LetterDateTime = txtLetterDate.Text;
            letterDateTime.ShowAs = drpDateType.SelectedValue;


            ECEClass.Priority priority = new ECEClass.Priority();
            priority.Code = drpLetterPriority.SelectedItem.Value;
            priority.Name = drpLetterPriority.SelectedItem.Text;


            ECEClass.Classification classification = new ECEClass.Classification();
            classification.Code = drpLetterClassification.SelectedItem.Value;
            classification.Name = drpLetterClassification.SelectedItem.Text;


            ECEClass.Keywords letterKeyword = new ECEClass.Keywords();
            letterKeyword.Keyword = txtKeyword.Text;

            /////////////////////////////////////////////////////////////////
            //loop to get all letters
            //here assumed only one letter

            ECEClass.Origin origin = new ECEClass.Origin();
            origin.Description = txtOriginFileDesc.Text;
            origin.ContentType = drpOriginFileType.SelectedItem.Text;
            string pathToSaveOrigin = "E:\\sample\\";
            upldFilePath.SaveAs(pathToSaveOrigin + upldFilePath.FileName);
            origin.encodedBase64String = ece.createECEBase64EncodedText(pathToSaveOrigin + upldFilePath.FileName);
            FileInfo fiO=new FileInfo(pathToSaveOrigin + upldFilePath.FileName);
            origin.Extension = fiO.Extension.Remove(0,1);//remove " ."
            ECEClass.Origins origins = new ECEClass.Origins();
            origins.addOrigin(origin);

            /////////////////////////////////////////////////////
            ECEClass.Attachment attachment = new ECEClass.Attachment();
            attachment.ContentType = drpAttachmentFileType.SelectedItem.Text;
            attachment.Description = txtAttchFileDesc.Text;
            string pathToSaveAttachment = "E:\\sample\\";
            upldAttachFilePath.SaveAs(pathToSaveAttachment + upldAttachFilePath.FileName);
            attachment.encodedBase64String = ece.createECEBase64EncodedText(pathToSaveAttachment + upldAttachFilePath.FileName);
            FileInfo fiA = new FileInfo(pathToSaveAttachment + upldAttachFilePath.FileName);
            attachment.Extension = fiA.Extension.Remove(0,1);
            ECEClass.Attachments attachments = new ECEClass.Attachments();
            attachments.addAttachment(attachment);

            ///////////////////////////////////////////

            ECEClass.Receiver receiver = new ECEClass.Receiver();
            receiver.Code =txtReceiverCode.Text;// "125;234";
            receiver.Department =txtReceiverDepartment0.Text;
            receiver.Name =txtReceiverName.Text;//
            receiver.Organization = txtReceiverOrg.Text;
            receiver.Position = txtReceiverPosition.Text;
            receiver.ReceiveType = drpReceiverType.SelectedItem.Text;
           
            ////////////////////////////////////////////////////////////

            otherReceiver = new ECEClass.OtherReceiver();
            otherReceiver.Code = txtOtherReceiverCode.Text;
            otherReceiver.Department = txtOtherReceiverDepartment.Text;
            otherReceiver.Name =txtOtherReceiverName.Text;
            otherReceiver.Organization =txtOtherReceiverOrg.Text;
            otherReceiver.Position =txtOtherReceiverPosition.Text;
            otherReceiver.ReceiveType = drpOtherReceiverType.SelectedItem.Text;
            ECEClass.OtherReceivers otherReceivers = new ECEClass.OtherReceivers();
            otherReceivers.addOtherReceiver(otherReceiver);

            ///////////////////////////////////////////////////////////////////////

            ECEClass.Sender letterSender = new ECEClass.Sender();
            letterSender.Code = txtSenderCode.Text;
            letterSender.Department = txtSenderDepartment0.Text;
            letterSender.Name = txtSenderName.Text;
            letterSender.Organization = txtSenderOrg.Text;
            letterSender.Position = txtSenderPosition.Text;

            //////////////////////////////////////////////////////////////////////


            string eceXml=ece.exportEceXml();
            ece.exportEceXml("e:\\sample2.xml");

        }

        protected void btnLoadEceXml_Click(object sender, EventArgs e)
        {

            ECEClass ece = new ECEClass();
            ece.loadECEXml("e:\\sample.xml");

            ECEClass.Subject subject = new ECEClass.Subject();
            txtSubject.Text = subject._Subject;
            /////////////////////////////////////////////////

            ECEClass.LetterNo letterno = new ECEClass.LetterNo();
             txtLetterNo.Text=letterno._LetterNo ;

            /////////////////////////////////////////////////////

            ECEClass.LetterDateTime letterDateTime = new ECEClass.LetterDateTime();
            txtLetterDate.Text = letterDateTime._LetterDateTime;
            drpDateType.SelectedValue = letterDateTime.ShowAs;
            //////////////////////////////////////////////////////

            ECEClass.Priority priority = new ECEClass.Priority();
            drpLetterPriority.SelectedItem.Value=priority.Code ;
            /////////////////////////////////////////////////////////

            ECEClass.Classification classification = new ECEClass.Classification();
            drpLetterClassification.SelectedItem.Value = classification.Code;
            ///////////////////////////////////////////////////////////

            ECEClass.Keywords letterKeyword = new ECEClass.Keywords();
            txtKeyword.Text = letterKeyword.Keyword;

            /////////////////////////////////////////////////////////////////

            ECEClass.Origins origins = new ECEClass.Origins();
            List<ECEClass.Origin> arrayOfOrigin=origins.getOrigins();
            foreach (var origin in arrayOfOrigin)
            {
                txtOriginFileDesc.Text=origin.Description;
                drpOriginFileType.SelectedItem.Text = origin.ContentType;
                ece.createBinaryFileFromECEText("E:\\sample\\ece\\"+origin.Description+"."+origin.Extension, origin.encodedBase64String);
            }
            

            /////////////////////////////////////////////////////
            ECEClass.Attachments attachments = new ECEClass.Attachments();
            List<ECEClass.Attachment> arrayOfAttachment=  attachments.getAttachment();
            foreach (var attachment in arrayOfAttachment)
            {
                txtAttchFileDesc.Text=attachment.Description ;
                drpAttachmentFileType.SelectedItem.Text = attachment.ContentType;
                ece.createBinaryFileFromECEText("E:\\sample\\ece\\" + attachment.Description + "." + attachment.Extension, attachment.encodedBase64String);
 
            }
         
            ///////////////////////////////////////////

            ECEClass.Receiver receiver = new ECEClass.Receiver();
            txtReceiverCode.Text                = receiver.Code;
            txtReceiverDepartment0.Text         = receiver.Department;
            txtReceiverName.Text                =receiver.Name  ;//
            txtReceiverOrg.Text                 =receiver.Organization ;
            txtReceiverPosition.Text            =receiver.Position ;
            drpReceiverType.SelectedItem.Text   =receiver.ReceiveType ;
            

            ////////////////////////////////////////////////////////////
            ECEClass.OtherReceivers otherReceivers = new ECEClass.OtherReceivers();
            List<ECEClass.OtherReceiver> arrayOfOtherReceiver = otherReceivers.getOtherRecivers();

            foreach (var otherReceiver in arrayOfOtherReceiver)
            {
                txtOtherReceiverCode.Text                   =otherReceiver.Code;
                txtOtherReceiverDepartment.Text             =otherReceiver.Department;
                txtOtherReceiverName.Text                   =otherReceiver.Name;
                txtOtherReceiverOrg.Text                    =otherReceiver.Organization;
                txtOtherReceiverPosition.Text               =otherReceiver.Position;
                drpOtherReceiverType.SelectedItem.Text      =otherReceiver.ReceiveType;
            }
            

            ///////////////////////////////////////////////////////////////////////

            ECEClass.Sender letterSender = new ECEClass.Sender();
            txtSenderCode.Text          =letterSender.Code;
            txtSenderDepartment0.Text   =letterSender.Department;
            txtSenderName.Text          =letterSender.Name;
            txtSenderOrg.Text           = letterSender.Organization;
            txtSenderPosition.Text      =letterSender.Position ;

            //////////////////////////////////////////////////////////////////////

        }

        protected void btnAddOtherReceiver_Click(object sender, EventArgs e)
        {
            if(otherReceiver==null)
                otherReceiver = new ECEClass.OtherReceiver();

            otherReceiver.Code = txtOtherReceiverCode.Text;
            otherReceiver.Department = txtOtherReceiverDepartment.Text;
            otherReceiver.Name = txtOtherReceiverName.Text;
            otherReceiver.Organization = txtOtherReceiverOrg.Text;
            otherReceiver.Position = txtOtherReceiverPosition.Text;
            otherReceiver.ReceiveType = drpOtherReceiverType.SelectedItem.Text;
            ECEClass.OtherReceivers otherReceivers = new ECEClass.OtherReceivers();
            otherReceivers.addOtherReceiver(otherReceiver);
        }

       


    }
}