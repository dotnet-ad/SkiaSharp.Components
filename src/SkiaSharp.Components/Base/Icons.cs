/// Source: https://feathericons.com/

using System;
namespace SkiaSharp.Components
{
    public static class Icons
    {
         private static Lazy<Icon> ActivityInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(22,12);
             source.AddPoly(new SKPoint [] { new SKPoint(22,12),new SKPoint(18,12),new SKPoint(15,21),new SKPoint(9,3),new SKPoint(6,12),new SKPoint(2,12),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Activity => ActivityInstance.Value;
         private static Lazy<Icon> AirplayInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M5 17H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h16a2 2 0 0 1 2 2v10a2 2 0 0 1-2 2h-1"), SKPathAddMode.Append);
             source.MoveTo(12,15);
             source.AddPoly(new SKPoint [] { new SKPoint(12,15),new SKPoint(17,21),new SKPoint(7,21),new SKPoint(12,15),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Airplay => AirplayInstance.Value;
         private static Lazy<Icon> AlertCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(12,8);
             source.LineTo(12,12);
             source.MoveTo(12,8);
             source.LineTo(12,12);
             source.MoveTo(12,16);
             source.LineTo(12,16);
             source.MoveTo(12,16);
             source.LineTo(12,16);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon AlertCircle => AlertCircleInstance.Value;
         private static Lazy<Icon> AlertOctagonInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(7.86F,2);
             source.AddPoly(new SKPoint [] { new SKPoint(7.86F,2),new SKPoint(16.14F,2),new SKPoint(22,7.86F),new SKPoint(22,16.14F),new SKPoint(16.14F,22),new SKPoint(7.86F,22),new SKPoint(2,16.14F),new SKPoint(2,7.86F),new SKPoint(7.86F,2),},true);
             source.MoveTo(12,8);
             source.LineTo(12,12);
             source.MoveTo(12,8);
             source.LineTo(12,12);
             source.MoveTo(12,16);
             source.LineTo(12,16);
             source.MoveTo(12,16);
             source.LineTo(12,16);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon AlertOctagon => AlertOctagonInstance.Value;
         private static Lazy<Icon> AlertTriangleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M10.29 3.86L1.82 18a2 2 0 0 0 1.71 3h16.94a2 2 0 0 0 1.71-3L13.71 3.86a2 2 0 0 0-3.42 0z"), SKPathAddMode.Append);
             source.MoveTo(12,9);
             source.LineTo(12,13);
             source.MoveTo(12,9);
             source.LineTo(12,13);
             source.MoveTo(12,17);
             source.LineTo(12,17);
             source.MoveTo(12,17);
             source.LineTo(12,17);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon AlertTriangle => AlertTriangleInstance.Value;
         private static Lazy<Icon> AlignCenterInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(18,10);
             source.LineTo(6,10);
             source.MoveTo(18,10);
             source.LineTo(6,10);
             source.MoveTo(21,6);
             source.LineTo(3,6);
             source.MoveTo(21,6);
             source.LineTo(3,6);
             source.MoveTo(21,14);
             source.LineTo(3,14);
             source.MoveTo(21,14);
             source.LineTo(3,14);
             source.MoveTo(18,18);
             source.LineTo(6,18);
             source.MoveTo(18,18);
             source.LineTo(6,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon AlignCenter => AlignCenterInstance.Value;
         private static Lazy<Icon> AlignJustifyInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(21,10);
             source.LineTo(3,10);
             source.MoveTo(21,10);
             source.LineTo(3,10);
             source.MoveTo(21,6);
             source.LineTo(3,6);
             source.MoveTo(21,6);
             source.LineTo(3,6);
             source.MoveTo(21,14);
             source.LineTo(3,14);
             source.MoveTo(21,14);
             source.LineTo(3,14);
             source.MoveTo(21,18);
             source.LineTo(3,18);
             source.MoveTo(21,18);
             source.LineTo(3,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon AlignJustify => AlignJustifyInstance.Value;
         private static Lazy<Icon> AlignLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(17,10);
             source.LineTo(3,10);
             source.MoveTo(17,10);
             source.LineTo(3,10);
             source.MoveTo(21,6);
             source.LineTo(3,6);
             source.MoveTo(21,6);
             source.LineTo(3,6);
             source.MoveTo(21,14);
             source.LineTo(3,14);
             source.MoveTo(21,14);
             source.LineTo(3,14);
             source.MoveTo(17,18);
             source.LineTo(3,18);
             source.MoveTo(17,18);
             source.LineTo(3,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon AlignLeft => AlignLeftInstance.Value;
         private static Lazy<Icon> AlignRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(21,10);
             source.LineTo(7,10);
             source.MoveTo(21,10);
             source.LineTo(7,10);
             source.MoveTo(21,6);
             source.LineTo(3,6);
             source.MoveTo(21,6);
             source.LineTo(3,6);
             source.MoveTo(21,14);
             source.LineTo(3,14);
             source.MoveTo(21,14);
             source.LineTo(3,14);
             source.MoveTo(21,18);
             source.LineTo(7,18);
             source.MoveTo(21,18);
             source.LineTo(7,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon AlignRight => AlignRightInstance.Value;
         private static Lazy<Icon> AnchorInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,5,3);
             source.MoveTo(12,22);
             source.LineTo(12,8);
             source.MoveTo(12,22);
             source.LineTo(12,8);
             source.AddPath(SKPath.ParseSvgPathData("M5 12H2a10 10 0 0 0 20 0h-3"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Anchor => AnchorInstance.Value;
         private static Lazy<Icon> ApertureInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(14.31F,8);
             source.LineTo(20.05F,17.94F);
             source.MoveTo(14.31F,8);
             source.LineTo(20.05F,17.94F);
             source.MoveTo(9.69F,8);
             source.LineTo(21.17F,8);
             source.MoveTo(9.69F,8);
             source.LineTo(21.17F,8);
             source.MoveTo(7.38F,12);
             source.LineTo(13.12F,2.06F);
             source.MoveTo(7.38F,12);
             source.LineTo(13.12F,2.06F);
             source.MoveTo(9.69F,16);
             source.LineTo(3.95F,6.06F);
             source.MoveTo(9.69F,16);
             source.LineTo(3.95F,6.06F);
             source.MoveTo(14.31F,16);
             source.LineTo(2.83F,16);
             source.MoveTo(14.31F,16);
             source.LineTo(2.83F,16);
             source.MoveTo(16.62F,12);
             source.LineTo(10.88F,21.94F);
             source.MoveTo(16.62F,12);
             source.LineTo(10.88F,21.94F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Aperture => ApertureInstance.Value;
         private static Lazy<Icon> ArchiveInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(21,8);
             source.AddPoly(new SKPoint [] { new SKPoint(21,8),new SKPoint(21,21),new SKPoint(3,21),new SKPoint(3,8),},false);
             source.AddRect(SKRect.Create(1,3,22,5));
             source.MoveTo(10,12);
             source.LineTo(14,12);
             source.MoveTo(10,12);
             source.LineTo(14,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Archive => ArchiveInstance.Value;
         private static Lazy<Icon> ArrowDownCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(8,12);
             source.AddPoly(new SKPoint [] { new SKPoint(8,12),new SKPoint(12,16),new SKPoint(16,12),},false);
             source.MoveTo(12,8);
             source.LineTo(12,16);
             source.MoveTo(12,8);
             source.LineTo(12,16);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowDownCircle => ArrowDownCircleInstance.Value;
         private static Lazy<Icon> ArrowDownLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(17,7);
             source.LineTo(7,17);
             source.MoveTo(17,7);
             source.LineTo(7,17);
             source.MoveTo(17,17);
             source.AddPoly(new SKPoint [] { new SKPoint(17,17),new SKPoint(7,17),new SKPoint(7,7),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowDownLeft => ArrowDownLeftInstance.Value;
         private static Lazy<Icon> ArrowDownRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(7,7);
             source.LineTo(17,17);
             source.MoveTo(7,7);
             source.LineTo(17,17);
             source.MoveTo(17,7);
             source.AddPoly(new SKPoint [] { new SKPoint(17,7),new SKPoint(17,17),new SKPoint(7,17),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowDownRight => ArrowDownRightInstance.Value;
         private static Lazy<Icon> ArrowDownInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,5);
             source.LineTo(12,19);
             source.MoveTo(12,5);
             source.LineTo(12,19);
             source.MoveTo(19,12);
             source.AddPoly(new SKPoint [] { new SKPoint(19,12),new SKPoint(12,19),new SKPoint(5,12),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowDown => ArrowDownInstance.Value;
         private static Lazy<Icon> ArrowLeftCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(12,8);
             source.AddPoly(new SKPoint [] { new SKPoint(12,8),new SKPoint(8,12),new SKPoint(12,16),},false);
             source.MoveTo(16,12);
             source.LineTo(8,12);
             source.MoveTo(16,12);
             source.LineTo(8,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowLeftCircle => ArrowLeftCircleInstance.Value;
         private static Lazy<Icon> ArrowLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(19,12);
             source.LineTo(5,12);
             source.MoveTo(19,12);
             source.LineTo(5,12);
             source.MoveTo(12,19);
             source.AddPoly(new SKPoint [] { new SKPoint(12,19),new SKPoint(5,12),new SKPoint(12,5),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowLeft => ArrowLeftInstance.Value;
         private static Lazy<Icon> ArrowRightCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(12,16);
             source.AddPoly(new SKPoint [] { new SKPoint(12,16),new SKPoint(16,12),new SKPoint(12,8),},false);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowRightCircle => ArrowRightCircleInstance.Value;
         private static Lazy<Icon> ArrowRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(5,12);
             source.LineTo(19,12);
             source.MoveTo(5,12);
             source.LineTo(19,12);
             source.MoveTo(12,5);
             source.AddPoly(new SKPoint [] { new SKPoint(12,5),new SKPoint(19,12),new SKPoint(12,19),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowRight => ArrowRightInstance.Value;
         private static Lazy<Icon> ArrowUpCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(16,12);
             source.AddPoly(new SKPoint [] { new SKPoint(16,12),new SKPoint(12,8),new SKPoint(8,12),},false);
             source.MoveTo(12,16);
             source.LineTo(12,8);
             source.MoveTo(12,16);
             source.LineTo(12,8);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowUpCircle => ArrowUpCircleInstance.Value;
         private static Lazy<Icon> ArrowUpLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(17,17);
             source.LineTo(7,7);
             source.MoveTo(17,17);
             source.LineTo(7,7);
             source.MoveTo(7,17);
             source.AddPoly(new SKPoint [] { new SKPoint(7,17),new SKPoint(7,7),new SKPoint(17,7),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowUpLeft => ArrowUpLeftInstance.Value;
         private static Lazy<Icon> ArrowUpRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(7,17);
             source.LineTo(17,7);
             source.MoveTo(7,17);
             source.LineTo(17,7);
             source.MoveTo(7,7);
             source.AddPoly(new SKPoint [] { new SKPoint(7,7),new SKPoint(17,7),new SKPoint(17,17),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowUpRight => ArrowUpRightInstance.Value;
         private static Lazy<Icon> ArrowUpInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,19);
             source.LineTo(12,5);
             source.MoveTo(12,19);
             source.LineTo(12,5);
             source.MoveTo(5,12);
             source.AddPoly(new SKPoint [] { new SKPoint(5,12),new SKPoint(12,5),new SKPoint(19,12),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ArrowUp => ArrowUpInstance.Value;
         private static Lazy<Icon> AtSignInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,4);
             source.AddPath(SKPath.ParseSvgPathData("M16 8v5a3 3 0 0 0 6 0v-1a10 10 0 1 0-3.92 7.94"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon AtSign => AtSignInstance.Value;
         private static Lazy<Icon> AwardInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,8,7);
             source.MoveTo(8.21F,13.89F);
             source.AddPoly(new SKPoint [] { new SKPoint(8.21F,13.89F),new SKPoint(7,23),new SKPoint(12,20),new SKPoint(17,23),new SKPoint(15.79F,13.88F),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Award => AwardInstance.Value;
         private static Lazy<Icon> BarChart2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(18,20);
             source.LineTo(18,10);
             source.MoveTo(18,20);
             source.LineTo(18,10);
             source.MoveTo(12,20);
             source.LineTo(12,4);
             source.MoveTo(12,20);
             source.LineTo(12,4);
             source.MoveTo(6,20);
             source.LineTo(6,14);
             source.MoveTo(6,20);
             source.LineTo(6,14);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon BarChart2 => BarChart2Instance.Value;
         private static Lazy<Icon> BarChartInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,20);
             source.LineTo(12,10);
             source.MoveTo(12,20);
             source.LineTo(12,10);
             source.MoveTo(18,20);
             source.LineTo(18,4);
             source.MoveTo(18,20);
             source.LineTo(18,4);
             source.MoveTo(6,20);
             source.LineTo(6,16);
             source.MoveTo(6,20);
             source.LineTo(6,16);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon BarChart => BarChartInstance.Value;
         private static Lazy<Icon> BatteryChargingInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M5 18H3a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h3.19M15 6h2a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2h-3.19"), SKPathAddMode.Append);
             source.MoveTo(23,13);
             source.LineTo(23,11);
             source.MoveTo(23,13);
             source.LineTo(23,11);
             source.MoveTo(11,6);
             source.AddPoly(new SKPoint [] { new SKPoint(11,6),new SKPoint(7,12),new SKPoint(13,12),new SKPoint(9,18),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon BatteryCharging => BatteryChargingInstance.Value;
         private static Lazy<Icon> BatteryInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(1,6,18,12));
             source.MoveTo(23,13);
             source.LineTo(23,11);
             source.MoveTo(23,13);
             source.LineTo(23,11);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Battery => BatteryInstance.Value;
         private static Lazy<Icon> BellOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M8.56 2.9A7 7 0 0 1 19 9v4m-2 4H2a3 3 0 0 0 3-3V9a7 7 0 0 1 .78-3.22M13.73 21a2 2 0 0 1-3.46 0"), SKPathAddMode.Append);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon BellOff => BellOffInstance.Value;
         private static Lazy<Icon> BellInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22 17H2a3 3 0 0 0 3-3V9a7 7 0 0 1 14 0v5a3 3 0 0 0 3 3zm-8.27 4a2 2 0 0 1-3.46 0"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Bell => BellInstance.Value;
         private static Lazy<Icon> BluetoothInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(6.5F,6.5F);
             source.AddPoly(new SKPoint [] { new SKPoint(6.5F,6.5F),new SKPoint(17.5F,17.5F),new SKPoint(12,23),new SKPoint(12,1),new SKPoint(17.5F,6.5F),new SKPoint(6.5F,17.5F),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Bluetooth => BluetoothInstance.Value;
         private static Lazy<Icon> BoldInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M6 4h8a4 4 0 0 1 4 4 4 4 0 0 1-4 4H6z"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M6 12h9a4 4 0 0 1 4 4 4 4 0 0 1-4 4H6z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Bold => BoldInstance.Value;
         private static Lazy<Icon> BookOpenInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M2 3h6a4 4 0 0 1 4 4v14a3 3 0 0 0-3-3H2z"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M22 3h-6a4 4 0 0 0-4 4v14a3 3 0 0 1 3-3h7z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon BookOpen => BookOpenInstance.Value;
         private static Lazy<Icon> BookInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M4 19.5A2.5 2.5 0 0 1 6.5 17H20"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M6.5 2H20v20H6.5A2.5 2.5 0 0 1 4 19.5v-15A2.5 2.5 0 0 1 6.5 2z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Book => BookInstance.Value;
         private static Lazy<Icon> BookmarkInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M19 21l-7-5-7 5V5a2 2 0 0 1 2-2h10a2 2 0 0 1 2 2z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Bookmark => BookmarkInstance.Value;
         private static Lazy<Icon> BoxInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M12.89 1.45l8 4A2 2 0 0 1 22 7.24v9.53a2 2 0 0 1-1.11 1.79l-8 4a2 2 0 0 1-1.79 0l-8-4a2 2 0 0 1-1.1-1.8V7.24a2 2 0 0 1 1.11-1.79l8-4a2 2 0 0 1 1.78 0z"), SKPathAddMode.Append);
             source.MoveTo(2.32F,6.16F);
             source.AddPoly(new SKPoint [] { new SKPoint(2.32F,6.16F),new SKPoint(12,11),new SKPoint(21.68F,6.16F),},false);
             source.MoveTo(12,22.76F);
             source.LineTo(12,11);
             source.MoveTo(12,22.76F);
             source.LineTo(12,11);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Box => BoxInstance.Value;
         private static Lazy<Icon> BriefcaseInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(2,7,20,14));
             source.AddPath(SKPath.ParseSvgPathData("M16 21V5a2 2 0 0 0-2-2h-4a2 2 0 0 0-2 2v16"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Briefcase => BriefcaseInstance.Value;
         private static Lazy<Icon> CalendarInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,4,18,18));
             source.MoveTo(16,2);
             source.LineTo(16,6);
             source.MoveTo(16,2);
             source.LineTo(16,6);
             source.MoveTo(8,2);
             source.LineTo(8,6);
             source.MoveTo(8,2);
             source.LineTo(8,6);
             source.MoveTo(3,10);
             source.LineTo(21,10);
             source.MoveTo(3,10);
             source.LineTo(21,10);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Calendar => CalendarInstance.Value;
         private static Lazy<Icon> CameraOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.AddPath(SKPath.ParseSvgPathData("M21 21H3a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h3m3-3h6l2 3h4a2 2 0 0 1 2 2v9.34m-7.72-2.06a4 4 0 1 1-5.56-5.56"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CameraOff => CameraOffInstance.Value;
         private static Lazy<Icon> CameraInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M23 19a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h4l2-3h6l2 3h4a2 2 0 0 1 2 2z"), SKPathAddMode.Append);
             source.AddCircle(12,13,4);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Camera => CameraInstance.Value;
         private static Lazy<Icon> CastInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M2 16.1A5 5 0 0 1 5.9 20M2 12.05A9 9 0 0 1 9.95 20M2 8V6a2 2 0 0 1 2-2h16a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2h-6"), SKPathAddMode.Append);
             source.MoveTo(2,20);
             source.LineTo(2,20);
             source.MoveTo(2,20);
             source.LineTo(2,20);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Cast => CastInstance.Value;
         private static Lazy<Icon> CheckCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22 11.08V12a10 10 0 1 1-5.93-9.14"), SKPathAddMode.Append);
             source.MoveTo(22,4);
             source.AddPoly(new SKPoint [] { new SKPoint(22,4),new SKPoint(12,14.01F),new SKPoint(9,11.01F),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CheckCircle => CheckCircleInstance.Value;
         private static Lazy<Icon> CheckSquareInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(9,11);
             source.AddPoly(new SKPoint [] { new SKPoint(9,11),new SKPoint(12,14),new SKPoint(22,4),},false);
             source.AddPath(SKPath.ParseSvgPathData("M21 12v7a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h11"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CheckSquare => CheckSquareInstance.Value;
         private static Lazy<Icon> CheckInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(20,6);
             source.AddPoly(new SKPoint [] { new SKPoint(20,6),new SKPoint(9,17),new SKPoint(4,12),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Check => CheckInstance.Value;
         private static Lazy<Icon> ChevronDownInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(6,9);
             source.AddPoly(new SKPoint [] { new SKPoint(6,9),new SKPoint(12,15),new SKPoint(18,9),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ChevronDown => ChevronDownInstance.Value;
         private static Lazy<Icon> ChevronLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(15,18);
             source.AddPoly(new SKPoint [] { new SKPoint(15,18),new SKPoint(9,12),new SKPoint(15,6),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ChevronLeft => ChevronLeftInstance.Value;
         private static Lazy<Icon> ChevronRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(9,18);
             source.AddPoly(new SKPoint [] { new SKPoint(9,18),new SKPoint(15,12),new SKPoint(9,6),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ChevronRight => ChevronRightInstance.Value;
         private static Lazy<Icon> ChevronUpInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(18,15);
             source.AddPoly(new SKPoint [] { new SKPoint(18,15),new SKPoint(12,9),new SKPoint(6,15),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ChevronUp => ChevronUpInstance.Value;
         private static Lazy<Icon> ChevronsDownInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(7,13);
             source.AddPoly(new SKPoint [] { new SKPoint(7,13),new SKPoint(12,18),new SKPoint(17,13),},false);
             source.MoveTo(7,6);
             source.AddPoly(new SKPoint [] { new SKPoint(7,6),new SKPoint(12,11),new SKPoint(17,6),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ChevronsDown => ChevronsDownInstance.Value;
         private static Lazy<Icon> ChevronsLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(11,17);
             source.AddPoly(new SKPoint [] { new SKPoint(11,17),new SKPoint(6,12),new SKPoint(11,7),},false);
             source.MoveTo(18,17);
             source.AddPoly(new SKPoint [] { new SKPoint(18,17),new SKPoint(13,12),new SKPoint(18,7),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ChevronsLeft => ChevronsLeftInstance.Value;
         private static Lazy<Icon> ChevronsRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(13,17);
             source.AddPoly(new SKPoint [] { new SKPoint(13,17),new SKPoint(18,12),new SKPoint(13,7),},false);
             source.MoveTo(6,17);
             source.AddPoly(new SKPoint [] { new SKPoint(6,17),new SKPoint(11,12),new SKPoint(6,7),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ChevronsRight => ChevronsRightInstance.Value;
         private static Lazy<Icon> ChevronsUpInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(17,11);
             source.AddPoly(new SKPoint [] { new SKPoint(17,11),new SKPoint(12,6),new SKPoint(7,11),},false);
             source.MoveTo(17,18);
             source.AddPoly(new SKPoint [] { new SKPoint(17,18),new SKPoint(12,13),new SKPoint(7,18),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ChevronsUp => ChevronsUpInstance.Value;
         private static Lazy<Icon> ChromeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.AddCircle(12,12,4);
             source.MoveTo(21.17F,8);
             source.LineTo(12,8);
             source.MoveTo(21.17F,8);
             source.LineTo(12,8);
             source.MoveTo(3.95F,6.06F);
             source.LineTo(8.54F,14);
             source.MoveTo(3.95F,6.06F);
             source.LineTo(8.54F,14);
             source.MoveTo(10.88F,21.94F);
             source.LineTo(15.46F,14);
             source.MoveTo(10.88F,21.94F);
             source.LineTo(15.46F,14);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Chrome => ChromeInstance.Value;
         private static Lazy<Icon> CircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Circle => CircleInstance.Value;
         private static Lazy<Icon> ClipboardInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M16 4h2a2 2 0 0 1 2 2v14a2 2 0 0 1-2 2H6a2 2 0 0 1-2-2V6a2 2 0 0 1 2-2h2"), SKPathAddMode.Append);
             source.AddRect(SKRect.Create(8,2,8,4));
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Clipboard => ClipboardInstance.Value;
         private static Lazy<Icon> ClockInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(12,6);
             source.AddPoly(new SKPoint [] { new SKPoint(12,6),new SKPoint(12,12),new SKPoint(16,14),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Clock => ClockInstance.Value;
         private static Lazy<Icon> CloudDrizzleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(8,19);
             source.LineTo(8,21);
             source.MoveTo(8,19);
             source.LineTo(8,21);
             source.MoveTo(8,13);
             source.LineTo(8,15);
             source.MoveTo(8,13);
             source.LineTo(8,15);
             source.MoveTo(16,19);
             source.LineTo(16,21);
             source.MoveTo(16,19);
             source.LineTo(16,21);
             source.MoveTo(16,13);
             source.LineTo(16,15);
             source.MoveTo(16,13);
             source.LineTo(16,15);
             source.MoveTo(12,21);
             source.LineTo(12,23);
             source.MoveTo(12,21);
             source.LineTo(12,23);
             source.MoveTo(12,15);
             source.LineTo(12,17);
             source.MoveTo(12,15);
             source.LineTo(12,17);
             source.AddPath(SKPath.ParseSvgPathData("M20 16.58A5 5 0 0 0 18 7h-1.26A8 8 0 1 0 4 15.25"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CloudDrizzle => CloudDrizzleInstance.Value;
         private static Lazy<Icon> CloudLightningInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M19 16.9A5 5 0 0 0 18 7h-1.26a8 8 0 1 0-11.62 9"), SKPathAddMode.Append);
             source.MoveTo(13,11);
             source.AddPoly(new SKPoint [] { new SKPoint(13,11),new SKPoint(9,17),new SKPoint(15,17),new SKPoint(11,23),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CloudLightning => CloudLightningInstance.Value;
         private static Lazy<Icon> CloudOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22.61 16.95A5 5 0 0 0 18 10h-1.26a8 8 0 0 0-7.05-6M5 5a8 8 0 0 0 4 15h9a5 5 0 0 0 1.7-.3"), SKPathAddMode.Append);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CloudOff => CloudOffInstance.Value;
         private static Lazy<Icon> CloudRainInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(16,13);
             source.LineTo(16,21);
             source.MoveTo(16,13);
             source.LineTo(16,21);
             source.MoveTo(8,13);
             source.LineTo(8,21);
             source.MoveTo(8,13);
             source.LineTo(8,21);
             source.MoveTo(12,15);
             source.LineTo(12,23);
             source.MoveTo(12,15);
             source.LineTo(12,23);
             source.AddPath(SKPath.ParseSvgPathData("M20 16.58A5 5 0 0 0 18 7h-1.26A8 8 0 1 0 4 15.25"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CloudRain => CloudRainInstance.Value;
         private static Lazy<Icon> CloudSnowInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M20 17.58A5 5 0 0 0 18 8h-1.26A8 8 0 1 0 4 16.25"), SKPathAddMode.Append);
             source.MoveTo(8,16);
             source.LineTo(8,16);
             source.MoveTo(8,16);
             source.LineTo(8,16);
             source.MoveTo(8,20);
             source.LineTo(8,20);
             source.MoveTo(8,20);
             source.LineTo(8,20);
             source.MoveTo(12,18);
             source.LineTo(12,18);
             source.MoveTo(12,18);
             source.LineTo(12,18);
             source.MoveTo(12,22);
             source.LineTo(12,22);
             source.MoveTo(12,22);
             source.LineTo(12,22);
             source.MoveTo(16,16);
             source.LineTo(16,16);
             source.MoveTo(16,16);
             source.LineTo(16,16);
             source.MoveTo(16,20);
             source.LineTo(16,20);
             source.MoveTo(16,20);
             source.LineTo(16,20);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CloudSnow => CloudSnowInstance.Value;
         private static Lazy<Icon> CloudInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M18 10h-1.26A8 8 0 1 0 9 20h9a5 5 0 0 0 0-10z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Cloud => CloudInstance.Value;
         private static Lazy<Icon> CodeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(16,18);
             source.AddPoly(new SKPoint [] { new SKPoint(16,18),new SKPoint(22,12),new SKPoint(16,6),},false);
             source.MoveTo(8,6);
             source.AddPoly(new SKPoint [] { new SKPoint(8,6),new SKPoint(2,12),new SKPoint(8,18),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Code => CodeInstance.Value;
         private static Lazy<Icon> CodepenInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,2);
             source.AddPoly(new SKPoint [] { new SKPoint(12,2),new SKPoint(22,8.5F),new SKPoint(22,15.5F),new SKPoint(12,22),new SKPoint(2,15.5F),new SKPoint(2,8.5F),new SKPoint(12,2),},true);
             source.MoveTo(12,22);
             source.LineTo(12,15.5F);
             source.MoveTo(12,22);
             source.LineTo(12,15.5F);
             source.MoveTo(22,8.5F);
             source.AddPoly(new SKPoint [] { new SKPoint(22,8.5F),new SKPoint(12,15.5F),new SKPoint(2,8.5F),},false);
             source.MoveTo(2,15.5F);
             source.AddPoly(new SKPoint [] { new SKPoint(2,15.5F),new SKPoint(12,8.5F),new SKPoint(22,15.5F),},false);
             source.MoveTo(12,2);
             source.LineTo(12,8.5F);
             source.MoveTo(12,2);
             source.LineTo(12,8.5F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Codepen => CodepenInstance.Value;
         private static Lazy<Icon> CommandInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M18 3a3 3 0 0 0-3 3v12a3 3 0 0 0 3 3 3 3 0 0 0 3-3 3 3 0 0 0-3-3H6a3 3 0 0 0-3 3 3 3 0 0 0 3 3 3 3 0 0 0 3-3V6a3 3 0 0 0-3-3 3 3 0 0 0-3 3 3 3 0 0 0 3 3h12a3 3 0 0 0 3-3 3 3 0 0 0-3-3z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Command => CommandInstance.Value;
         private static Lazy<Icon> CompassInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(16.24F,7.76F);
             source.AddPoly(new SKPoint [] { new SKPoint(16.24F,7.76F),new SKPoint(14.12F,14.12F),new SKPoint(7.76F,16.24F),new SKPoint(9.88F,9.88F),new SKPoint(16.24F,7.76F),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Compass => CompassInstance.Value;
         private static Lazy<Icon> CopyInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(9,9,13,13));
             source.AddPath(SKPath.ParseSvgPathData("M5 15H4a2 2 0 0 1-2-2V4a2 2 0 0 1 2-2h9a2 2 0 0 1 2 2v1"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Copy => CopyInstance.Value;
         private static Lazy<Icon> CornerDownLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(9,10);
             source.AddPoly(new SKPoint [] { new SKPoint(9,10),new SKPoint(4,15),new SKPoint(9,20),},false);
             source.AddPath(SKPath.ParseSvgPathData("M20 4v7a4 4 0 0 1-4 4H4"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CornerDownLeft => CornerDownLeftInstance.Value;
         private static Lazy<Icon> CornerDownRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(15,10);
             source.AddPoly(new SKPoint [] { new SKPoint(15,10),new SKPoint(20,15),new SKPoint(15,20),},false);
             source.AddPath(SKPath.ParseSvgPathData("M4 4v7a4 4 0 0 0 4 4h12"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CornerDownRight => CornerDownRightInstance.Value;
         private static Lazy<Icon> CornerLeftDownInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(14,15);
             source.AddPoly(new SKPoint [] { new SKPoint(14,15),new SKPoint(9,20),new SKPoint(4,15),},false);
             source.AddPath(SKPath.ParseSvgPathData("M20 4h-7a4 4 0 0 0-4 4v12"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CornerLeftDown => CornerLeftDownInstance.Value;
         private static Lazy<Icon> CornerLeftUpInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(14,9);
             source.AddPoly(new SKPoint [] { new SKPoint(14,9),new SKPoint(9,4),new SKPoint(4,9),},false);
             source.AddPath(SKPath.ParseSvgPathData("M20 20h-7a4 4 0 0 1-4-4V4"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CornerLeftUp => CornerLeftUpInstance.Value;
         private static Lazy<Icon> CornerRightDownInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(10,15);
             source.AddPoly(new SKPoint [] { new SKPoint(10,15),new SKPoint(15,20),new SKPoint(20,15),},false);
             source.AddPath(SKPath.ParseSvgPathData("M4 4h7a4 4 0 0 1 4 4v12"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CornerRightDown => CornerRightDownInstance.Value;
         private static Lazy<Icon> CornerRightUpInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(10,9);
             source.AddPoly(new SKPoint [] { new SKPoint(10,9),new SKPoint(15,4),new SKPoint(20,9),},false);
             source.AddPath(SKPath.ParseSvgPathData("M4 20h7a4 4 0 0 0 4-4V4"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CornerRightUp => CornerRightUpInstance.Value;
         private static Lazy<Icon> CornerUpLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(9,14);
             source.AddPoly(new SKPoint [] { new SKPoint(9,14),new SKPoint(4,9),new SKPoint(9,4),},false);
             source.AddPath(SKPath.ParseSvgPathData("M20 20v-7a4 4 0 0 0-4-4H4"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CornerUpLeft => CornerUpLeftInstance.Value;
         private static Lazy<Icon> CornerUpRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(15,14);
             source.AddPoly(new SKPoint [] { new SKPoint(15,14),new SKPoint(20,9),new SKPoint(15,4),},false);
             source.AddPath(SKPath.ParseSvgPathData("M4 20v-7a4 4 0 0 1 4-4h12"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CornerUpRight => CornerUpRightInstance.Value;
         private static Lazy<Icon> CpuInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(4,4,16,16));
             source.AddRect(SKRect.Create(9,9,6,6));
             source.MoveTo(9,1);
             source.LineTo(9,4);
             source.MoveTo(9,1);
             source.LineTo(9,4);
             source.MoveTo(15,1);
             source.LineTo(15,4);
             source.MoveTo(15,1);
             source.LineTo(15,4);
             source.MoveTo(9,20);
             source.LineTo(9,23);
             source.MoveTo(9,20);
             source.LineTo(9,23);
             source.MoveTo(15,20);
             source.LineTo(15,23);
             source.MoveTo(15,20);
             source.LineTo(15,23);
             source.MoveTo(20,9);
             source.LineTo(23,9);
             source.MoveTo(20,9);
             source.LineTo(23,9);
             source.MoveTo(20,14);
             source.LineTo(23,14);
             source.MoveTo(20,14);
             source.LineTo(23,14);
             source.MoveTo(1,9);
             source.LineTo(4,9);
             source.MoveTo(1,9);
             source.LineTo(4,9);
             source.MoveTo(1,14);
             source.LineTo(4,14);
             source.MoveTo(1,14);
             source.LineTo(4,14);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Cpu => CpuInstance.Value;
         private static Lazy<Icon> CreditCardInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(1,4,22,16));
             source.MoveTo(1,10);
             source.LineTo(23,10);
             source.MoveTo(1,10);
             source.LineTo(23,10);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon CreditCard => CreditCardInstance.Value;
         private static Lazy<Icon> CropInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M6.13 1L6 16a2 2 0 0 0 2 2h15"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M1 6.13L16 6a2 2 0 0 1 2 2v15"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Crop => CropInstance.Value;
         private static Lazy<Icon> CrosshairInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(22,12);
             source.LineTo(18,12);
             source.MoveTo(22,12);
             source.LineTo(18,12);
             source.MoveTo(6,12);
             source.LineTo(2,12);
             source.MoveTo(6,12);
             source.LineTo(2,12);
             source.MoveTo(12,6);
             source.LineTo(12,2);
             source.MoveTo(12,6);
             source.LineTo(12,2);
             source.MoveTo(12,22);
             source.LineTo(12,18);
             source.MoveTo(12,22);
             source.LineTo(12,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Crosshair => CrosshairInstance.Value;
         private static Lazy<Icon> DatabaseInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21 12c0 1.66-4 3-9 3s-9-1.34-9-3"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M3 5v14c0 1.66 4 3 9 3s9-1.34 9-3V5"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Database => DatabaseInstance.Value;
         private static Lazy<Icon> DeleteInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21 4H8l-7 8 7 8h13a2 2 0 0 0 2-2V6a2 2 0 0 0-2-2z"), SKPathAddMode.Append);
             source.MoveTo(18,9);
             source.LineTo(12,15);
             source.MoveTo(18,9);
             source.LineTo(12,15);
             source.MoveTo(12,9);
             source.LineTo(18,15);
             source.MoveTo(12,9);
             source.LineTo(18,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Delete => DeleteInstance.Value;
         private static Lazy<Icon> DiscInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.AddCircle(12,12,3);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Disc => DiscInstance.Value;
         private static Lazy<Icon> DollarSignInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,1);
             source.LineTo(12,23);
             source.MoveTo(12,1);
             source.LineTo(12,23);
             source.AddPath(SKPath.ParseSvgPathData("M17 5H9.5a3.5 3.5 0 0 0 0 7h5a3.5 3.5 0 0 1 0 7H6"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon DollarSign => DollarSignInstance.Value;
         private static Lazy<Icon> DownloadCloudInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(8,17);
             source.AddPoly(new SKPoint [] { new SKPoint(8,17),new SKPoint(12,21),new SKPoint(16,17),},false);
             source.MoveTo(12,12);
             source.LineTo(12,21);
             source.MoveTo(12,12);
             source.LineTo(12,21);
             source.AddPath(SKPath.ParseSvgPathData("M20.88 18.09A5 5 0 0 0 18 9h-1.26A8 8 0 1 0 3 16.29"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon DownloadCloud => DownloadCloudInstance.Value;
         private static Lazy<Icon> DownloadInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21 15v4a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2v-4"), SKPathAddMode.Append);
             source.MoveTo(7,10);
             source.AddPoly(new SKPoint [] { new SKPoint(7,10),new SKPoint(12,15),new SKPoint(17,10),},false);
             source.MoveTo(12,15);
             source.LineTo(12,3);
             source.MoveTo(12,15);
             source.LineTo(12,3);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Download => DownloadInstance.Value;
         private static Lazy<Icon> DropletInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M12 2.69l5.66 5.66a8 8 0 1 1-11.31 0z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Droplet => DropletInstance.Value;
         private static Lazy<Icon> Edit2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(16,3);
             source.AddPoly(new SKPoint [] { new SKPoint(16,3),new SKPoint(21,8),new SKPoint(8,21),new SKPoint(3,21),new SKPoint(3,16),new SKPoint(16,3),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Edit2 => Edit2Instance.Value;
         private static Lazy<Icon> Edit3Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(14,2);
             source.AddPoly(new SKPoint [] { new SKPoint(14,2),new SKPoint(18,6),new SKPoint(7,17),new SKPoint(3,17),new SKPoint(3,13),new SKPoint(14,2),},true);
             source.MoveTo(3,22);
             source.LineTo(21,22);
             source.MoveTo(3,22);
             source.LineTo(21,22);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Edit3 => Edit3Instance.Value;
         private static Lazy<Icon> EditInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M20 14.66V20a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V6a2 2 0 0 1 2-2h5.34"), SKPathAddMode.Append);
             source.MoveTo(18,2);
             source.AddPoly(new SKPoint [] { new SKPoint(18,2),new SKPoint(22,6),new SKPoint(12,16),new SKPoint(8,16),new SKPoint(8,12),new SKPoint(18,2),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Edit => EditInstance.Value;
         private static Lazy<Icon> ExternalLinkInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M18 13v6a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h6"), SKPathAddMode.Append);
             source.MoveTo(15,3);
             source.AddPoly(new SKPoint [] { new SKPoint(15,3),new SKPoint(21,3),new SKPoint(21,9),},false);
             source.MoveTo(10,14);
             source.LineTo(21,3);
             source.MoveTo(10,14);
             source.LineTo(21,3);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ExternalLink => ExternalLinkInstance.Value;
         private static Lazy<Icon> EyeOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M17.94 17.94A10.07 10.07 0 0 1 12 20c-7 0-11-8-11-8a18.45 18.45 0 0 1 5.06-5.94M9.9 4.24A9.12 9.12 0 0 1 12 4c7 0 11 8 11 8a18.5 18.5 0 0 1-2.16 3.19m-6.72-1.07a3 3 0 1 1-4.24-4.24"), SKPathAddMode.Append);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon EyeOff => EyeOffInstance.Value;
         private static Lazy<Icon> EyeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M1 12s4-8 11-8 11 8 11 8-4 8-11 8-11-8-11-8z"), SKPathAddMode.Append);
             source.AddCircle(12,12,3);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Eye => EyeInstance.Value;
         private static Lazy<Icon> FacebookInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M18 2h-3a5 5 0 0 0-5 5v3H7v4h3v8h4v-8h3l1-4h-4V7a1 1 0 0 1 1-1h3z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Facebook => FacebookInstance.Value;
         private static Lazy<Icon> FastForwardInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(13,19);
             source.AddPoly(new SKPoint [] { new SKPoint(13,19),new SKPoint(22,12),new SKPoint(13,5),new SKPoint(13,19),},true);
             source.MoveTo(2,19);
             source.AddPoly(new SKPoint [] { new SKPoint(2,19),new SKPoint(11,12),new SKPoint(2,5),new SKPoint(2,19),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon FastForward => FastForwardInstance.Value;
         private static Lazy<Icon> FeatherInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M20.24 12.24a6 6 0 0 0-8.49-8.49L5 10.5V19h8.5z"), SKPathAddMode.Append);
             source.MoveTo(16,8);
             source.LineTo(2,22);
             source.MoveTo(16,8);
             source.LineTo(2,22);
             source.MoveTo(17,15);
             source.LineTo(9,15);
             source.MoveTo(17,15);
             source.LineTo(9,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Feather => FeatherInstance.Value;
         private static Lazy<Icon> FileMinusInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"), SKPathAddMode.Append);
             source.MoveTo(14,2);
             source.AddPoly(new SKPoint [] { new SKPoint(14,2),new SKPoint(14,8),new SKPoint(20,8),},false);
             source.MoveTo(9,15);
             source.LineTo(15,15);
             source.MoveTo(9,15);
             source.LineTo(15,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon FileMinus => FileMinusInstance.Value;
         private static Lazy<Icon> FilePlusInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"), SKPathAddMode.Append);
             source.MoveTo(14,2);
             source.AddPoly(new SKPoint [] { new SKPoint(14,2),new SKPoint(14,8),new SKPoint(20,8),},false);
             source.MoveTo(12,18);
             source.LineTo(12,12);
             source.MoveTo(12,18);
             source.LineTo(12,12);
             source.MoveTo(9,15);
             source.LineTo(15,15);
             source.MoveTo(9,15);
             source.LineTo(15,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon FilePlus => FilePlusInstance.Value;
         private static Lazy<Icon> FileTextInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"), SKPathAddMode.Append);
             source.MoveTo(14,2);
             source.AddPoly(new SKPoint [] { new SKPoint(14,2),new SKPoint(14,8),new SKPoint(20,8),},false);
             source.MoveTo(16,13);
             source.LineTo(8,13);
             source.MoveTo(16,13);
             source.LineTo(8,13);
             source.MoveTo(16,17);
             source.LineTo(8,17);
             source.MoveTo(16,17);
             source.LineTo(8,17);
             source.MoveTo(10,9);
             source.AddPoly(new SKPoint [] { new SKPoint(10,9),new SKPoint(9,9),new SKPoint(8,9),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon FileText => FileTextInstance.Value;
         private static Lazy<Icon> FileInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z"), SKPathAddMode.Append);
             source.MoveTo(13,2);
             source.AddPoly(new SKPoint [] { new SKPoint(13,2),new SKPoint(13,9),new SKPoint(20,9),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon File => FileInstance.Value;
         private static Lazy<Icon> FilmInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(2,2,20,20));
             source.MoveTo(7,2);
             source.LineTo(7,22);
             source.MoveTo(7,2);
             source.LineTo(7,22);
             source.MoveTo(17,2);
             source.LineTo(17,22);
             source.MoveTo(17,2);
             source.LineTo(17,22);
             source.MoveTo(2,12);
             source.LineTo(22,12);
             source.MoveTo(2,12);
             source.LineTo(22,12);
             source.MoveTo(2,7);
             source.LineTo(7,7);
             source.MoveTo(2,7);
             source.LineTo(7,7);
             source.MoveTo(2,17);
             source.LineTo(7,17);
             source.MoveTo(2,17);
             source.LineTo(7,17);
             source.MoveTo(17,17);
             source.LineTo(22,17);
             source.MoveTo(17,17);
             source.LineTo(22,17);
             source.MoveTo(17,7);
             source.LineTo(22,7);
             source.MoveTo(17,7);
             source.LineTo(22,7);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Film => FilmInstance.Value;
         private static Lazy<Icon> FilterInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(22,3);
             source.AddPoly(new SKPoint [] { new SKPoint(22,3),new SKPoint(2,3),new SKPoint(10,12.46F),new SKPoint(10,19),new SKPoint(14,21),new SKPoint(14,12.46F),new SKPoint(22,3),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Filter => FilterInstance.Value;
         private static Lazy<Icon> FlagInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M4 15s1-1 4-1 5 2 8 2 4-1 4-1V3s-1 1-4 1-5-2-8-2-4 1-4 1z"), SKPathAddMode.Append);
             source.MoveTo(4,22);
             source.LineTo(4,15);
             source.MoveTo(4,22);
             source.LineTo(4,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Flag => FlagInstance.Value;
         private static Lazy<Icon> FolderMinusInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22 19a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h5l2 3h9a2 2 0 0 1 2 2z"), SKPathAddMode.Append);
             source.MoveTo(9,14);
             source.LineTo(15,14);
             source.MoveTo(9,14);
             source.LineTo(15,14);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon FolderMinus => FolderMinusInstance.Value;
         private static Lazy<Icon> FolderPlusInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22 19a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h5l2 3h9a2 2 0 0 1 2 2z"), SKPathAddMode.Append);
             source.MoveTo(12,11);
             source.LineTo(12,17);
             source.MoveTo(12,11);
             source.LineTo(12,17);
             source.MoveTo(9,14);
             source.LineTo(15,14);
             source.MoveTo(9,14);
             source.LineTo(15,14);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon FolderPlus => FolderPlusInstance.Value;
         private static Lazy<Icon> FolderInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22 19a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h5l2 3h9a2 2 0 0 1 2 2z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Folder => FolderInstance.Value;
         private static Lazy<Icon> GiftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(20,12);
             source.AddPoly(new SKPoint [] { new SKPoint(20,12),new SKPoint(20,22),new SKPoint(4,22),new SKPoint(4,12),},false);
             source.AddRect(SKRect.Create(2,7,20,5));
             source.MoveTo(12,22);
             source.LineTo(12,7);
             source.MoveTo(12,22);
             source.LineTo(12,7);
             source.AddPath(SKPath.ParseSvgPathData("M12 7H7.5a2.5 2.5 0 0 1 0-5C11 2 12 7 12 7z"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M12 7h4.5a2.5 2.5 0 0 0 0-5C13 2 12 7 12 7z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Gift => GiftInstance.Value;
         private static Lazy<Icon> GitBranchInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(6,3);
             source.LineTo(6,15);
             source.MoveTo(6,3);
             source.LineTo(6,15);
             source.AddCircle(18,6,3);
             source.AddCircle(6,18,3);
             source.AddPath(SKPath.ParseSvgPathData("M18 9a9 9 0 0 1-9 9"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon GitBranch => GitBranchInstance.Value;
         private static Lazy<Icon> GitCommitInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,4);
             source.MoveTo(1.05F,12);
             source.LineTo(7,12);
             source.MoveTo(1.05F,12);
             source.LineTo(7,12);
             source.MoveTo(17.01F,12);
             source.LineTo(22.96F,12);
             source.MoveTo(17.01F,12);
             source.LineTo(22.96F,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon GitCommit => GitCommitInstance.Value;
         private static Lazy<Icon> GitMergeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(18,18,3);
             source.AddCircle(6,6,3);
             source.AddPath(SKPath.ParseSvgPathData("M6 21V9a9 9 0 0 0 9 9"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon GitMerge => GitMergeInstance.Value;
         private static Lazy<Icon> GitPullRequestInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(18,18,3);
             source.AddCircle(6,6,3);
             source.AddPath(SKPath.ParseSvgPathData("M13 6h3a2 2 0 0 1 2 2v7"), SKPathAddMode.Append);
             source.MoveTo(6,9);
             source.LineTo(6,21);
             source.MoveTo(6,9);
             source.LineTo(6,21);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon GitPullRequest => GitPullRequestInstance.Value;
         private static Lazy<Icon> GithubInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M9 19c-5 1.5-5-2.5-7-3m14 6v-3.87a3.37 3.37 0 0 0-.94-2.61c3.14-.35 6.44-1.54 6.44-7A5.44 5.44 0 0 0 20 4.77 5.07 5.07 0 0 0 19.91 1S18.73.65 16 2.48a13.38 13.38 0 0 0-7 0C6.27.65 5.09 1 5.09 1A5.07 5.07 0 0 0 5 4.77a5.44 5.44 0 0 0-1.5 3.78c0 5.42 3.3 6.61 6.44 7A3.37 3.37 0 0 0 9 18.13V22"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Github => GithubInstance.Value;
         private static Lazy<Icon> GitlabInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22.65 14.39L12 22.13 1.35 14.39a.84.84 0 0 1-.3-.94l1.22-3.78 2.44-7.51A.42.42 0 0 1 4.82 2a.43.43 0 0 1 .58 0 .42.42 0 0 1 .11.18l2.44 7.49h8.1l2.44-7.51A.42.42 0 0 1 18.6 2a.43.43 0 0 1 .58 0 .42.42 0 0 1 .11.18l2.44 7.51L23 13.45a.84.84 0 0 1-.35.94z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Gitlab => GitlabInstance.Value;
         private static Lazy<Icon> GlobeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(2,12);
             source.LineTo(22,12);
             source.MoveTo(2,12);
             source.LineTo(22,12);
             source.AddPath(SKPath.ParseSvgPathData("M12 2a15.3 15.3 0 0 1 4 10 15.3 15.3 0 0 1-4 10 15.3 15.3 0 0 1-4-10 15.3 15.3 0 0 1 4-10z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Globe => GlobeInstance.Value;
         private static Lazy<Icon> GridInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,3,7,7));
             source.AddRect(SKRect.Create(14,3,7,7));
             source.AddRect(SKRect.Create(14,14,7,7));
             source.AddRect(SKRect.Create(3,14,7,7));
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Grid => GridInstance.Value;
         private static Lazy<Icon> HardDriveInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(22,12);
             source.LineTo(2,12);
             source.MoveTo(22,12);
             source.LineTo(2,12);
             source.AddPath(SKPath.ParseSvgPathData("M5.45 5.11L2 12v6a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2v-6l-3.45-6.89A2 2 0 0 0 16.76 4H7.24a2 2 0 0 0-1.79 1.11z"), SKPathAddMode.Append);
             source.MoveTo(6,16);
             source.LineTo(6,16);
             source.MoveTo(6,16);
             source.LineTo(6,16);
             source.MoveTo(10,16);
             source.LineTo(10,16);
             source.MoveTo(10,16);
             source.LineTo(10,16);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon HardDrive => HardDriveInstance.Value;
         private static Lazy<Icon> HashInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(4,9);
             source.LineTo(20,9);
             source.MoveTo(4,9);
             source.LineTo(20,9);
             source.MoveTo(4,15);
             source.LineTo(20,15);
             source.MoveTo(4,15);
             source.LineTo(20,15);
             source.MoveTo(10,3);
             source.LineTo(8,21);
             source.MoveTo(10,3);
             source.LineTo(8,21);
             source.MoveTo(16,3);
             source.LineTo(14,21);
             source.MoveTo(16,3);
             source.LineTo(14,21);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Hash => HashInstance.Value;
         private static Lazy<Icon> HeadphonesInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M3 18v-6a9 9 0 0 1 18 0v6"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M21 19a2 2 0 0 1-2 2h-1a2 2 0 0 1-2-2v-3a2 2 0 0 1 2-2h3zM3 19a2 2 0 0 0 2 2h1a2 2 0 0 0 2-2v-3a2 2 0 0 0-2-2H3z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Headphones => HeadphonesInstance.Value;
         private static Lazy<Icon> HeartInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M20.84 4.61a5.5 5.5 0 0 0-7.78 0L12 5.67l-1.06-1.06a5.5 5.5 0 0 0-7.78 7.78l1.06 1.06L12 21.23l7.78-7.78 1.06-1.06a5.5 5.5 0 0 0 0-7.78z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Heart => HeartInstance.Value;
         private static Lazy<Icon> HelpCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.AddPath(SKPath.ParseSvgPathData("M9.09 9a3 3 0 0 1 5.83 1c0 2-3 3-3 3"), SKPathAddMode.Append);
             source.MoveTo(12,17);
             source.LineTo(12,17);
             source.MoveTo(12,17);
             source.LineTo(12,17);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon HelpCircle => HelpCircleInstance.Value;
         private static Lazy<Icon> HomeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"), SKPathAddMode.Append);
             source.MoveTo(9,22);
             source.AddPoly(new SKPoint [] { new SKPoint(9,22),new SKPoint(9,12),new SKPoint(15,12),new SKPoint(15,22),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Home => HomeInstance.Value;
         private static Lazy<Icon> ImageInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,3,18,18));
             source.AddCircle(8.5F,8.5F,1.5F);
             source.MoveTo(21,15);
             source.AddPoly(new SKPoint [] { new SKPoint(21,15),new SKPoint(16,10),new SKPoint(5,21),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Image => ImageInstance.Value;
         private static Lazy<Icon> InboxInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(22,12);
             source.AddPoly(new SKPoint [] { new SKPoint(22,12),new SKPoint(16,12),new SKPoint(14,15),new SKPoint(10,15),new SKPoint(8,12),new SKPoint(2,12),},false);
             source.AddPath(SKPath.ParseSvgPathData("M5.45 5.11L2 12v6a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2v-6l-3.45-6.89A2 2 0 0 0 16.76 4H7.24a2 2 0 0 0-1.79 1.11z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Inbox => InboxInstance.Value;
         private static Lazy<Icon> InfoInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(12,16);
             source.LineTo(12,12);
             source.MoveTo(12,16);
             source.LineTo(12,12);
             source.MoveTo(12,8);
             source.LineTo(12,8);
             source.MoveTo(12,8);
             source.LineTo(12,8);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Info => InfoInstance.Value;
         private static Lazy<Icon> InstagramInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(2,2,20,20));
             source.AddPath(SKPath.ParseSvgPathData("M16 11.37A4 4 0 1 1 12.63 8 4 4 0 0 1 16 11.37z"), SKPathAddMode.Append);
             source.MoveTo(17.5F,6.5F);
             source.LineTo(17.5F,6.5F);
             source.MoveTo(17.5F,6.5F);
             source.LineTo(17.5F,6.5F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Instagram => InstagramInstance.Value;
         private static Lazy<Icon> ItalicInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(19,4);
             source.LineTo(10,4);
             source.MoveTo(19,4);
             source.LineTo(10,4);
             source.MoveTo(14,20);
             source.LineTo(5,20);
             source.MoveTo(14,20);
             source.LineTo(5,20);
             source.MoveTo(15,4);
             source.LineTo(9,20);
             source.MoveTo(15,4);
             source.LineTo(9,20);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Italic => ItalicInstance.Value;
         private static Lazy<Icon> LayersInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,2);
             source.AddPoly(new SKPoint [] { new SKPoint(12,2),new SKPoint(2,7),new SKPoint(12,12),new SKPoint(22,7),new SKPoint(12,2),},true);
             source.MoveTo(2,17);
             source.AddPoly(new SKPoint [] { new SKPoint(2,17),new SKPoint(12,22),new SKPoint(22,17),},false);
             source.MoveTo(2,12);
             source.AddPoly(new SKPoint [] { new SKPoint(2,12),new SKPoint(12,17),new SKPoint(22,12),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Layers => LayersInstance.Value;
         private static Lazy<Icon> LayoutInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,3,18,18));
             source.MoveTo(3,9);
             source.LineTo(21,9);
             source.MoveTo(3,9);
             source.LineTo(21,9);
             source.MoveTo(9,21);
             source.LineTo(9,9);
             source.MoveTo(9,21);
             source.LineTo(9,9);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Layout => LayoutInstance.Value;
         private static Lazy<Icon> LifeBuoyInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.AddCircle(12,12,4);
             source.MoveTo(4.93F,4.93F);
             source.LineTo(9.17F,9.17F);
             source.MoveTo(4.93F,4.93F);
             source.LineTo(9.17F,9.17F);
             source.MoveTo(14.83F,14.83F);
             source.LineTo(19.07F,19.07F);
             source.MoveTo(14.83F,14.83F);
             source.LineTo(19.07F,19.07F);
             source.MoveTo(14.83F,9.17F);
             source.LineTo(19.07F,4.93F);
             source.MoveTo(14.83F,9.17F);
             source.LineTo(19.07F,4.93F);
             source.MoveTo(14.83F,9.17F);
             source.LineTo(18.36F,5.64F);
             source.MoveTo(14.83F,9.17F);
             source.LineTo(18.36F,5.64F);
             source.MoveTo(4.93F,19.07F);
             source.LineTo(9.17F,14.83F);
             source.MoveTo(4.93F,19.07F);
             source.LineTo(9.17F,14.83F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon LifeBuoy => LifeBuoyInstance.Value;
         private static Lazy<Icon> Link2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M15 7h3a5 5 0 0 1 5 5 5 5 0 0 1-5 5h-3m-6 0H6a5 5 0 0 1-5-5 5 5 0 0 1 5-5h3"), SKPathAddMode.Append);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Link2 => Link2Instance.Value;
         private static Lazy<Icon> LinkInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M10 13a5 5 0 0 0 7.54.54l3-3a5 5 0 0 0-7.07-7.07l-1.72 1.71"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M14 11a5 5 0 0 0-7.54-.54l-3 3a5 5 0 0 0 7.07 7.07l1.71-1.71"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Link => LinkInstance.Value;
         private static Lazy<Icon> LinkedinInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M16 8a6 6 0 0 1 6 6v7h-4v-7a2 2 0 0 0-2-2 2 2 0 0 0-2 2v7h-4v-7a6 6 0 0 1 6-6z"), SKPathAddMode.Append);
             source.AddRect(SKRect.Create(2,9,4,12));
             source.AddCircle(4,4,2);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Linkedin => LinkedinInstance.Value;
         private static Lazy<Icon> ListInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(8,6);
             source.LineTo(21,6);
             source.MoveTo(8,6);
             source.LineTo(21,6);
             source.MoveTo(8,12);
             source.LineTo(21,12);
             source.MoveTo(8,12);
             source.LineTo(21,12);
             source.MoveTo(8,18);
             source.LineTo(21,18);
             source.MoveTo(8,18);
             source.LineTo(21,18);
             source.MoveTo(3,6);
             source.LineTo(3,6);
             source.MoveTo(3,6);
             source.LineTo(3,6);
             source.MoveTo(3,12);
             source.LineTo(3,12);
             source.MoveTo(3,12);
             source.LineTo(3,12);
             source.MoveTo(3,18);
             source.LineTo(3,18);
             source.MoveTo(3,18);
             source.LineTo(3,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon List => ListInstance.Value;
         private static Lazy<Icon> LoaderInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,2);
             source.LineTo(12,6);
             source.MoveTo(12,2);
             source.LineTo(12,6);
             source.MoveTo(12,18);
             source.LineTo(12,22);
             source.MoveTo(12,18);
             source.LineTo(12,22);
             source.MoveTo(4.93F,4.93F);
             source.LineTo(7.76F,7.76F);
             source.MoveTo(4.93F,4.93F);
             source.LineTo(7.76F,7.76F);
             source.MoveTo(16.24F,16.24F);
             source.LineTo(19.07F,19.07F);
             source.MoveTo(16.24F,16.24F);
             source.LineTo(19.07F,19.07F);
             source.MoveTo(2,12);
             source.LineTo(6,12);
             source.MoveTo(2,12);
             source.LineTo(6,12);
             source.MoveTo(18,12);
             source.LineTo(22,12);
             source.MoveTo(18,12);
             source.LineTo(22,12);
             source.MoveTo(4.93F,19.07F);
             source.LineTo(7.76F,16.24F);
             source.MoveTo(4.93F,19.07F);
             source.LineTo(7.76F,16.24F);
             source.MoveTo(16.24F,7.76F);
             source.LineTo(19.07F,4.93F);
             source.MoveTo(16.24F,7.76F);
             source.LineTo(19.07F,4.93F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Loader => LoaderInstance.Value;
         private static Lazy<Icon> LockInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,11,18,11));
             source.AddPath(SKPath.ParseSvgPathData("M7 11V7a5 5 0 0 1 10 0v4"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Lock => LockInstance.Value;
         private static Lazy<Icon> LogInInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M15 3h4a2 2 0 0 1 2 2v14a2 2 0 0 1-2 2h-4"), SKPathAddMode.Append);
             source.MoveTo(10,17);
             source.AddPoly(new SKPoint [] { new SKPoint(10,17),new SKPoint(15,12),new SKPoint(10,7),},false);
             source.MoveTo(15,12);
             source.LineTo(3,12);
             source.MoveTo(15,12);
             source.LineTo(3,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon LogIn => LogInInstance.Value;
         private static Lazy<Icon> LogOutInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M9 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h4"), SKPathAddMode.Append);
             source.MoveTo(16,17);
             source.AddPoly(new SKPoint [] { new SKPoint(16,17),new SKPoint(21,12),new SKPoint(16,7),},false);
             source.MoveTo(21,12);
             source.LineTo(9,12);
             source.MoveTo(21,12);
             source.LineTo(9,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon LogOut => LogOutInstance.Value;
         private static Lazy<Icon> MailInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M4 4h16c1.1 0 2 .9 2 2v12c0 1.1-.9 2-2 2H4c-1.1 0-2-.9-2-2V6c0-1.1.9-2 2-2z"), SKPathAddMode.Append);
             source.MoveTo(22.6F,12.13F);
             source.AddPoly(new SKPoint [] { new SKPoint(22.6F,12.13F),new SKPoint(2.6F,0),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Mail => MailInstance.Value;
         private static Lazy<Icon> MapPinInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21 10c0 7-9 13-9 13s-9-6-9-13a9 9 0 0 1 18 0z"), SKPathAddMode.Append);
             source.AddCircle(12,10,3);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon MapPin => MapPinInstance.Value;
         private static Lazy<Icon> MapInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(1,6);
             source.AddPoly(new SKPoint [] { new SKPoint(1,6),new SKPoint(1,22),new SKPoint(8,18),new SKPoint(16,22),new SKPoint(23,18),new SKPoint(23,2),new SKPoint(16,6),new SKPoint(8,2),new SKPoint(1,6),},true);
             source.MoveTo(8,2);
             source.LineTo(8,18);
             source.MoveTo(8,2);
             source.LineTo(8,18);
             source.MoveTo(16,6);
             source.LineTo(16,22);
             source.MoveTo(16,6);
             source.LineTo(16,22);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Map => MapInstance.Value;
         private static Lazy<Icon> Maximize2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(15,3);
             source.AddPoly(new SKPoint [] { new SKPoint(15,3),new SKPoint(21,3),new SKPoint(21,9),},false);
             source.MoveTo(9,21);
             source.AddPoly(new SKPoint [] { new SKPoint(9,21),new SKPoint(3,21),new SKPoint(3,15),},false);
             source.MoveTo(21,3);
             source.LineTo(14,10);
             source.MoveTo(21,3);
             source.LineTo(14,10);
             source.MoveTo(3,21);
             source.LineTo(10,14);
             source.MoveTo(3,21);
             source.LineTo(10,14);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Maximize2 => Maximize2Instance.Value;
         private static Lazy<Icon> MaximizeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M8 3H5a2 2 0 0 0-2 2v3m18 0V5a2 2 0 0 0-2-2h-3m0 18h3a2 2 0 0 0 2-2v-3M3 16v3a2 2 0 0 0 2 2h3"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Maximize => MaximizeInstance.Value;
         private static Lazy<Icon> MenuInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(3,12);
             source.LineTo(21,12);
             source.MoveTo(3,12);
             source.LineTo(21,12);
             source.MoveTo(3,6);
             source.LineTo(21,6);
             source.MoveTo(3,6);
             source.LineTo(21,6);
             source.MoveTo(3,18);
             source.LineTo(21,18);
             source.MoveTo(3,18);
             source.LineTo(21,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Menu => MenuInstance.Value;
         private static Lazy<Icon> MessageCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21 11.5a8.38 8.38 0 0 1-.9 3.8 8.5 8.5 0 0 1-7.6 4.7 8.38 8.38 0 0 1-3.8-.9L3 21l1.9-5.7a8.38 8.38 0 0 1-.9-3.8 8.5 8.5 0 0 1 4.7-7.6 8.38 8.38 0 0 1 3.8-.9h.5a8.48 8.48 0 0 1 8 8v.5z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon MessageCircle => MessageCircleInstance.Value;
         private static Lazy<Icon> MessageSquareInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21 15a2 2 0 0 1-2 2H7l-4 4V5a2 2 0 0 1 2-2h14a2 2 0 0 1 2 2z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon MessageSquare => MessageSquareInstance.Value;
         private static Lazy<Icon> MicOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.AddPath(SKPath.ParseSvgPathData("M9 9v3a3 3 0 0 0 5.12 2.12M15 9.34V4a3 3 0 0 0-5.94-.6"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M17 16.95A7 7 0 0 1 5 12v-2m14 0v2a7 7 0 0 1-.11 1.23"), SKPathAddMode.Append);
             source.MoveTo(12,19);
             source.LineTo(12,23);
             source.MoveTo(12,19);
             source.LineTo(12,23);
             source.MoveTo(8,23);
             source.LineTo(16,23);
             source.MoveTo(8,23);
             source.LineTo(16,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon MicOff => MicOffInstance.Value;
         private static Lazy<Icon> MicInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M12 1a3 3 0 0 0-3 3v8a3 3 0 0 0 6 0V4a3 3 0 0 0-3-3z"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M19 10v2a7 7 0 0 1-14 0v-2"), SKPathAddMode.Append);
             source.MoveTo(12,19);
             source.LineTo(12,23);
             source.MoveTo(12,19);
             source.LineTo(12,23);
             source.MoveTo(8,23);
             source.LineTo(16,23);
             source.MoveTo(8,23);
             source.LineTo(16,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Mic => MicInstance.Value;
         private static Lazy<Icon> Minimize2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(4,14);
             source.AddPoly(new SKPoint [] { new SKPoint(4,14),new SKPoint(10,14),new SKPoint(10,20),},false);
             source.MoveTo(20,10);
             source.AddPoly(new SKPoint [] { new SKPoint(20,10),new SKPoint(14,10),new SKPoint(14,4),},false);
             source.MoveTo(14,10);
             source.LineTo(21,3);
             source.MoveTo(14,10);
             source.LineTo(21,3);
             source.MoveTo(3,21);
             source.LineTo(10,14);
             source.MoveTo(3,21);
             source.LineTo(10,14);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Minimize2 => Minimize2Instance.Value;
         private static Lazy<Icon> MinimizeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M8 3v3a2 2 0 0 1-2 2H3m18 0h-3a2 2 0 0 1-2-2V3m0 18v-3a2 2 0 0 1 2-2h3M3 16h3a2 2 0 0 1 2 2v3"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Minimize => MinimizeInstance.Value;
         private static Lazy<Icon> MinusCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon MinusCircle => MinusCircleInstance.Value;
         private static Lazy<Icon> MinusSquareInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,3,18,18));
             source.MoveTo(8,12);
             source.LineTo(16,12);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon MinusSquare => MinusSquareInstance.Value;
         private static Lazy<Icon> MinusInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(5,12);
             source.LineTo(19,12);
             source.MoveTo(5,12);
             source.LineTo(19,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Minus => MinusInstance.Value;
         private static Lazy<Icon> MonitorInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(2,3,20,14));
             source.MoveTo(8,21);
             source.LineTo(16,21);
             source.MoveTo(8,21);
             source.LineTo(16,21);
             source.MoveTo(12,17);
             source.LineTo(12,21);
             source.MoveTo(12,17);
             source.LineTo(12,21);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Monitor => MonitorInstance.Value;
         private static Lazy<Icon> MoonInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21 12.79A9 9 0 1 1 11.21 3 7 7 0 0 0 21 12.79z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Moon => MoonInstance.Value;
         private static Lazy<Icon> MoreHorizontalInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,1);
             source.AddCircle(19,12,1);
             source.AddCircle(5,12,1);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon MoreHorizontal => MoreHorizontalInstance.Value;
         private static Lazy<Icon> MoreVerticalInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,1);
             source.AddCircle(12,5,1);
             source.AddCircle(12,19,1);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon MoreVertical => MoreVerticalInstance.Value;
         private static Lazy<Icon> MoveInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(5,9);
             source.AddPoly(new SKPoint [] { new SKPoint(5,9),new SKPoint(2,12),new SKPoint(5,15),},false);
             source.MoveTo(9,5);
             source.AddPoly(new SKPoint [] { new SKPoint(9,5),new SKPoint(12,2),new SKPoint(15,5),},false);
             source.MoveTo(15,19);
             source.AddPoly(new SKPoint [] { new SKPoint(15,19),new SKPoint(12,22),new SKPoint(9,19),},false);
             source.MoveTo(19,9);
             source.AddPoly(new SKPoint [] { new SKPoint(19,9),new SKPoint(22,12),new SKPoint(19,15),},false);
             source.MoveTo(2,12);
             source.LineTo(22,12);
             source.MoveTo(2,12);
             source.LineTo(22,12);
             source.MoveTo(12,2);
             source.LineTo(12,22);
             source.MoveTo(12,2);
             source.LineTo(12,22);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Move => MoveInstance.Value;
         private static Lazy<Icon> MusicInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M9 17H5a2 2 0 0 0-2 2 2 2 0 0 0 2 2h2a2 2 0 0 0 2-2zm12-2h-4a2 2 0 0 0-2 2 2 2 0 0 0 2 2h2a2 2 0 0 0 2-2z"), SKPathAddMode.Append);
             source.MoveTo(9,17);
             source.AddPoly(new SKPoint [] { new SKPoint(9,17),new SKPoint(9,5),new SKPoint(21,3),new SKPoint(21,15),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Music => MusicInstance.Value;
         private static Lazy<Icon> Navigation2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,2);
             source.AddPoly(new SKPoint [] { new SKPoint(12,2),new SKPoint(19,21),new SKPoint(12,17),new SKPoint(5,21),new SKPoint(12,2),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Navigation2 => Navigation2Instance.Value;
         private static Lazy<Icon> NavigationInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(3,11);
             source.AddPoly(new SKPoint [] { new SKPoint(3,11),new SKPoint(22,2),new SKPoint(13,21),new SKPoint(11,13),new SKPoint(3,11),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Navigation => NavigationInstance.Value;
         private static Lazy<Icon> OctagonInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(7.86F,2);
             source.AddPoly(new SKPoint [] { new SKPoint(7.86F,2),new SKPoint(16.14F,2),new SKPoint(22,7.86F),new SKPoint(22,16.14F),new SKPoint(16.14F,22),new SKPoint(7.86F,22),new SKPoint(2,16.14F),new SKPoint(2,7.86F),new SKPoint(7.86F,2),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Octagon => OctagonInstance.Value;
         private static Lazy<Icon> PackageInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M12.89 1.45l8 4A2 2 0 0 1 22 7.24v9.53a2 2 0 0 1-1.11 1.79l-8 4a2 2 0 0 1-1.79 0l-8-4a2 2 0 0 1-1.1-1.8V7.24a2 2 0 0 1 1.11-1.79l8-4a2 2 0 0 1 1.78 0z"), SKPathAddMode.Append);
             source.MoveTo(2.32F,6.16F);
             source.AddPoly(new SKPoint [] { new SKPoint(2.32F,6.16F),new SKPoint(12,11),new SKPoint(21.68F,6.16F),},false);
             source.MoveTo(12,22.76F);
             source.LineTo(12,11);
             source.MoveTo(12,22.76F);
             source.LineTo(12,11);
             source.MoveTo(7,3.5F);
             source.LineTo(17,8.5F);
             source.MoveTo(7,3.5F);
             source.LineTo(17,8.5F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Package => PackageInstance.Value;
         private static Lazy<Icon> PaperclipInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21.44 11.05l-9.19 9.19a6 6 0 0 1-8.49-8.49l9.19-9.19a4 4 0 0 1 5.66 5.66l-9.2 9.19a2 2 0 0 1-2.83-2.83l8.49-8.48"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Paperclip => PaperclipInstance.Value;
         private static Lazy<Icon> PauseCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(10,15);
             source.LineTo(10,9);
             source.MoveTo(10,15);
             source.LineTo(10,9);
             source.MoveTo(14,15);
             source.LineTo(14,9);
             source.MoveTo(14,15);
             source.LineTo(14,9);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PauseCircle => PauseCircleInstance.Value;
         private static Lazy<Icon> PauseInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(6,4,4,16));
             source.AddRect(SKRect.Create(14,4,4,16));
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Pause => PauseInstance.Value;
         private static Lazy<Icon> PercentInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(19,5);
             source.LineTo(5,19);
             source.MoveTo(19,5);
             source.LineTo(5,19);
             source.AddCircle(6.5F,6.5F,2.5F);
             source.AddCircle(17.5F,17.5F,2.5F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Percent => PercentInstance.Value;
         private static Lazy<Icon> PhoneCallInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M15.05 5A5 5 0 0 1 19 8.95M15.05 1A9 9 0 0 1 23 8.94m-1 7.98v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PhoneCall => PhoneCallInstance.Value;
         private static Lazy<Icon> PhoneForwardedInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(19,1);
             source.AddPoly(new SKPoint [] { new SKPoint(19,1),new SKPoint(23,5),new SKPoint(19,9),},false);
             source.MoveTo(15,5);
             source.LineTo(23,5);
             source.MoveTo(15,5);
             source.LineTo(23,5);
             source.AddPath(SKPath.ParseSvgPathData("M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PhoneForwarded => PhoneForwardedInstance.Value;
         private static Lazy<Icon> PhoneIncomingInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(16,2);
             source.AddPoly(new SKPoint [] { new SKPoint(16,2),new SKPoint(16,8),new SKPoint(22,8),},false);
             source.MoveTo(23,1);
             source.LineTo(16,8);
             source.MoveTo(23,1);
             source.LineTo(16,8);
             source.AddPath(SKPath.ParseSvgPathData("M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PhoneIncoming => PhoneIncomingInstance.Value;
         private static Lazy<Icon> PhoneMissedInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(23,1);
             source.LineTo(17,7);
             source.MoveTo(23,1);
             source.LineTo(17,7);
             source.MoveTo(17,1);
             source.LineTo(23,7);
             source.MoveTo(17,1);
             source.LineTo(23,7);
             source.AddPath(SKPath.ParseSvgPathData("M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PhoneMissed => PhoneMissedInstance.Value;
         private static Lazy<Icon> PhoneOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M10.68 13.31a16 16 0 0 0 3.41 2.6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7 2 2 0 0 1 1.72 2v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.42 19.42 0 0 1-3.33-2.67m-2.67-3.34a19.79 19.79 0 0 1-3.07-8.63A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91"), SKPathAddMode.Append);
             source.MoveTo(23,1);
             source.LineTo(1,23);
             source.MoveTo(23,1);
             source.LineTo(1,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PhoneOff => PhoneOffInstance.Value;
         private static Lazy<Icon> PhoneOutgoingInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(23,7);
             source.AddPoly(new SKPoint [] { new SKPoint(23,7),new SKPoint(23,1),new SKPoint(17,1),},false);
             source.MoveTo(16,8);
             source.LineTo(23,1);
             source.MoveTo(16,8);
             source.LineTo(23,1);
             source.AddPath(SKPath.ParseSvgPathData("M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PhoneOutgoing => PhoneOutgoingInstance.Value;
         private static Lazy<Icon> PhoneInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Phone => PhoneInstance.Value;
         private static Lazy<Icon> PieChartInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21.21 15.89A10 10 0 1 1 8 2.83"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M22 12A10 10 0 0 0 12 2v10z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PieChart => PieChartInstance.Value;
         private static Lazy<Icon> PlayCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(10,8);
             source.AddPoly(new SKPoint [] { new SKPoint(10,8),new SKPoint(16,12),new SKPoint(10,16),new SKPoint(10,8),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PlayCircle => PlayCircleInstance.Value;
         private static Lazy<Icon> PlayInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(5,3);
             source.AddPoly(new SKPoint [] { new SKPoint(5,3),new SKPoint(19,12),new SKPoint(5,21),new SKPoint(5,3),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Play => PlayInstance.Value;
         private static Lazy<Icon> PlusCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(12,8);
             source.LineTo(12,16);
             source.MoveTo(12,8);
             source.LineTo(12,16);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PlusCircle => PlusCircleInstance.Value;
         private static Lazy<Icon> PlusSquareInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,3,18,18));
             source.MoveTo(12,8);
             source.LineTo(12,16);
             source.MoveTo(12,8);
             source.LineTo(12,16);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             source.MoveTo(8,12);
             source.LineTo(16,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon PlusSquare => PlusSquareInstance.Value;
         private static Lazy<Icon> PlusInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,5);
             source.LineTo(12,19);
             source.MoveTo(12,5);
             source.LineTo(12,19);
             source.MoveTo(5,12);
             source.LineTo(19,12);
             source.MoveTo(5,12);
             source.LineTo(19,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Plus => PlusInstance.Value;
         private static Lazy<Icon> PocketInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M4 3h16a2 2 0 0 1 2 2v6a10 10 0 0 1-10 10A10 10 0 0 1 2 11V5a2 2 0 0 1 2-2z"), SKPathAddMode.Append);
             source.MoveTo(8,10);
             source.AddPoly(new SKPoint [] { new SKPoint(8,10),new SKPoint(12,14),new SKPoint(16,10),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Pocket => PocketInstance.Value;
         private static Lazy<Icon> PowerInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M18.36 6.64a9 9 0 1 1-12.73 0"), SKPathAddMode.Append);
             source.MoveTo(12,2);
             source.LineTo(12,12);
             source.MoveTo(12,2);
             source.LineTo(12,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Power => PowerInstance.Value;
         private static Lazy<Icon> PrinterInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(6,9);
             source.AddPoly(new SKPoint [] { new SKPoint(6,9),new SKPoint(6,2),new SKPoint(18,2),new SKPoint(18,9),},false);
             source.AddPath(SKPath.ParseSvgPathData("M6 18H4a2 2 0 0 1-2-2v-5a2 2 0 0 1 2-2h16a2 2 0 0 1 2 2v5a2 2 0 0 1-2 2h-2"), SKPathAddMode.Append);
             source.AddRect(SKRect.Create(6,14,12,8));
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Printer => PrinterInstance.Value;
         private static Lazy<Icon> RadioInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,2);
             source.AddPath(SKPath.ParseSvgPathData("M16.24 7.76a6 6 0 0 1 0 8.49m-8.48-.01a6 6 0 0 1 0-8.49m11.31-2.82a10 10 0 0 1 0 14.14m-14.14 0a10 10 0 0 1 0-14.14"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Radio => RadioInstance.Value;
         private static Lazy<Icon> RefreshCcwInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(1,4);
             source.AddPoly(new SKPoint [] { new SKPoint(1,4),new SKPoint(1,10),new SKPoint(7,10),},false);
             source.MoveTo(23,20);
             source.AddPoly(new SKPoint [] { new SKPoint(23,20),new SKPoint(23,14),new SKPoint(17,14),},false);
             source.AddPath(SKPath.ParseSvgPathData("M20.49 9A9 9 0 0 0 5.64 5.64L1 10m22 4l-4.64 4.36A9 9 0 0 1 3.51 15"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon RefreshCcw => RefreshCcwInstance.Value;
         private static Lazy<Icon> RefreshCwInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(23,4);
             source.AddPoly(new SKPoint [] { new SKPoint(23,4),new SKPoint(23,10),new SKPoint(17,10),},false);
             source.MoveTo(1,20);
             source.AddPoly(new SKPoint [] { new SKPoint(1,20),new SKPoint(1,14),new SKPoint(7,14),},false);
             source.AddPath(SKPath.ParseSvgPathData("M3.51 9a9 9 0 0 1 14.85-3.36L23 10M1 14l4.64 4.36A9 9 0 0 0 20.49 15"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon RefreshCw => RefreshCwInstance.Value;
         private static Lazy<Icon> RepeatInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(17,1);
             source.AddPoly(new SKPoint [] { new SKPoint(17,1),new SKPoint(21,5),new SKPoint(17,9),},false);
             source.AddPath(SKPath.ParseSvgPathData("M3 11V9a4 4 0 0 1 4-4h14"), SKPathAddMode.Append);
             source.MoveTo(7,23);
             source.AddPoly(new SKPoint [] { new SKPoint(7,23),new SKPoint(3,19),new SKPoint(7,15),},false);
             source.AddPath(SKPath.ParseSvgPathData("M21 13v2a4 4 0 0 1-4 4H3"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Repeat => RepeatInstance.Value;
         private static Lazy<Icon> RewindInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(11,19);
             source.AddPoly(new SKPoint [] { new SKPoint(11,19),new SKPoint(2,12),new SKPoint(11,5),new SKPoint(11,19),},true);
             source.MoveTo(22,19);
             source.AddPoly(new SKPoint [] { new SKPoint(22,19),new SKPoint(13,12),new SKPoint(22,5),new SKPoint(22,19),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Rewind => RewindInstance.Value;
         private static Lazy<Icon> RotateCcwInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(1,4);
             source.AddPoly(new SKPoint [] { new SKPoint(1,4),new SKPoint(1,10),new SKPoint(7,10),},false);
             source.AddPath(SKPath.ParseSvgPathData("M3.51 15a9 9 0 1 0 2.13-9.36L1 10"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon RotateCcw => RotateCcwInstance.Value;
         private static Lazy<Icon> RotateCwInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(23,4);
             source.AddPoly(new SKPoint [] { new SKPoint(23,4),new SKPoint(23,10),new SKPoint(17,10),},false);
             source.AddPath(SKPath.ParseSvgPathData("M20.49 15a9 9 0 1 1-2.12-9.36L23 10"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon RotateCw => RotateCwInstance.Value;
         private static Lazy<Icon> RssInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M4 11a9 9 0 0 1 9 9"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M4 4a16 16 0 0 1 16 16"), SKPathAddMode.Append);
             source.AddCircle(5,19,1);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Rss => RssInstance.Value;
         private static Lazy<Icon> SaveInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M19 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h11l5 5v11a2 2 0 0 1-2 2z"), SKPathAddMode.Append);
             source.MoveTo(17,21);
             source.AddPoly(new SKPoint [] { new SKPoint(17,21),new SKPoint(17,13),new SKPoint(7,13),new SKPoint(7,21),},false);
             source.MoveTo(7,3);
             source.AddPoly(new SKPoint [] { new SKPoint(7,3),new SKPoint(7,8),new SKPoint(15,8),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Save => SaveInstance.Value;
         private static Lazy<Icon> ScissorsInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(6,6,3);
             source.AddCircle(6,18,3);
             source.MoveTo(20,4);
             source.LineTo(8.12F,15.88F);
             source.MoveTo(20,4);
             source.LineTo(8.12F,15.88F);
             source.MoveTo(14.47F,14.48F);
             source.LineTo(20,20);
             source.MoveTo(14.47F,14.48F);
             source.LineTo(20,20);
             source.MoveTo(8.12F,8.12F);
             source.LineTo(12,12);
             source.MoveTo(8.12F,8.12F);
             source.LineTo(12,12);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Scissors => ScissorsInstance.Value;
         private static Lazy<Icon> SearchInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(11,11,8);
             source.MoveTo(21,21);
             source.LineTo(16.65F,16.65F);
             source.MoveTo(21,21);
             source.LineTo(16.65F,16.65F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Search => SearchInstance.Value;
         private static Lazy<Icon> SendInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(22,2);
             source.LineTo(11,13);
             source.MoveTo(22,2);
             source.LineTo(11,13);
             source.MoveTo(22,2);
             source.AddPoly(new SKPoint [] { new SKPoint(22,2),new SKPoint(15,22),new SKPoint(11,13),new SKPoint(2,9),new SKPoint(22,2),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Send => SendInstance.Value;
         private static Lazy<Icon> ServerInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(2,2,20,8));
             source.AddRect(SKRect.Create(2,14,20,8));
             source.MoveTo(6,6);
             source.LineTo(6,6);
             source.MoveTo(6,6);
             source.LineTo(6,6);
             source.MoveTo(6,18);
             source.LineTo(6,18);
             source.MoveTo(6,18);
             source.LineTo(6,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Server => ServerInstance.Value;
         private static Lazy<Icon> SettingsInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,3);
             source.AddPath(SKPath.ParseSvgPathData("M19.4 15a1.65 1.65 0 0 0 .33 1.82l.06.06a2 2 0 0 1 0 2.83 2 2 0 0 1-2.83 0l-.06-.06a1.65 1.65 0 0 0-1.82-.33 1.65 1.65 0 0 0-1 1.51V21a2 2 0 0 1-2 2 2 2 0 0 1-2-2v-.09A1.65 1.65 0 0 0 9 19.4a1.65 1.65 0 0 0-1.82.33l-.06.06a2 2 0 0 1-2.83 0 2 2 0 0 1 0-2.83l.06-.06a1.65 1.65 0 0 0 .33-1.82 1.65 1.65 0 0 0-1.51-1H3a2 2 0 0 1-2-2 2 2 0 0 1 2-2h.09A1.65 1.65 0 0 0 4.6 9a1.65 1.65 0 0 0-.33-1.82l-.06-.06a2 2 0 0 1 0-2.83 2 2 0 0 1 2.83 0l.06.06a1.65 1.65 0 0 0 1.82.33H9a1.65 1.65 0 0 0 1-1.51V3a2 2 0 0 1 2-2 2 2 0 0 1 2 2v.09a1.65 1.65 0 0 0 1 1.51 1.65 1.65 0 0 0 1.82-.33l.06-.06a2 2 0 0 1 2.83 0 2 2 0 0 1 0 2.83l-.06.06a1.65 1.65 0 0 0-.33 1.82V9a1.65 1.65 0 0 0 1.51 1H21a2 2 0 0 1 2 2 2 2 0 0 1-2 2h-.09a1.65 1.65 0 0 0-1.51 1z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Settings => SettingsInstance.Value;
         private static Lazy<Icon> Share2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(18,5,3);
             source.AddCircle(6,12,3);
             source.AddCircle(18,19,3);
             source.MoveTo(8.59F,13.51F);
             source.LineTo(15.42F,17.49F);
             source.MoveTo(8.59F,13.51F);
             source.LineTo(15.42F,17.49F);
             source.MoveTo(15.41F,6.51F);
             source.LineTo(8.59F,10.49F);
             source.MoveTo(15.41F,6.51F);
             source.LineTo(8.59F,10.49F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Share2 => Share2Instance.Value;
         private static Lazy<Icon> ShareInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M4 12v8a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2v-8"), SKPathAddMode.Append);
             source.MoveTo(16,6);
             source.AddPoly(new SKPoint [] { new SKPoint(16,6),new SKPoint(12,2),new SKPoint(8,6),},false);
             source.MoveTo(12,2);
             source.LineTo(12,15);
             source.MoveTo(12,2);
             source.LineTo(12,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Share => ShareInstance.Value;
         private static Lazy<Icon> ShieldOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M19.69 14a6.9 6.9 0 0 0 .31-2V5l-8-3-3.16 1.18"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M4.73 4.73L4 5v7c0 6 8 10 8 10a20.29 20.29 0 0 0 5.62-4.38"), SKPathAddMode.Append);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ShieldOff => ShieldOffInstance.Value;
         private static Lazy<Icon> ShieldInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M12 22s8-4 8-10V5l-8-3-8 3v7c0 6 8 10 8 10z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Shield => ShieldInstance.Value;
         private static Lazy<Icon> ShoppingBagInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M6 2L3 6v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V6l-3-4z"), SKPathAddMode.Append);
             source.MoveTo(3,6);
             source.LineTo(21,6);
             source.MoveTo(3,6);
             source.LineTo(21,6);
             source.AddPath(SKPath.ParseSvgPathData("M16 10a4 4 0 0 1-8 0"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ShoppingBag => ShoppingBagInstance.Value;
         private static Lazy<Icon> ShoppingCartInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(9,21,1);
             source.AddCircle(20,21,1);
             source.AddPath(SKPath.ParseSvgPathData("M1 1h4l2.68 13.39a2 2 0 0 0 2 1.61h9.72a2 2 0 0 0 2-1.61L23 6H6"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ShoppingCart => ShoppingCartInstance.Value;
         private static Lazy<Icon> ShuffleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(16,3);
             source.AddPoly(new SKPoint [] { new SKPoint(16,3),new SKPoint(21,3),new SKPoint(21,8),},false);
             source.MoveTo(4,20);
             source.LineTo(21,3);
             source.MoveTo(4,20);
             source.LineTo(21,3);
             source.MoveTo(21,16);
             source.AddPoly(new SKPoint [] { new SKPoint(21,16),new SKPoint(21,21),new SKPoint(16,21),},false);
             source.MoveTo(15,15);
             source.LineTo(21,21);
             source.MoveTo(15,15);
             source.LineTo(21,21);
             source.MoveTo(4,4);
             source.LineTo(9,9);
             source.MoveTo(4,4);
             source.LineTo(9,9);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Shuffle => ShuffleInstance.Value;
         private static Lazy<Icon> SidebarInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,3,18,18));
             source.MoveTo(9,3);
             source.LineTo(9,21);
             source.MoveTo(9,3);
             source.LineTo(9,21);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Sidebar => SidebarInstance.Value;
         private static Lazy<Icon> SkipBackInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(19,20);
             source.AddPoly(new SKPoint [] { new SKPoint(19,20),new SKPoint(9,12),new SKPoint(19,4),new SKPoint(19,20),},true);
             source.MoveTo(5,19);
             source.LineTo(5,5);
             source.MoveTo(5,19);
             source.LineTo(5,5);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon SkipBack => SkipBackInstance.Value;
         private static Lazy<Icon> SkipForwardInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(5,4);
             source.AddPoly(new SKPoint [] { new SKPoint(5,4),new SKPoint(15,12),new SKPoint(5,20),new SKPoint(5,4),},true);
             source.MoveTo(19,5);
             source.LineTo(19,19);
             source.MoveTo(19,5);
             source.LineTo(19,19);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon SkipForward => SkipForwardInstance.Value;
         private static Lazy<Icon> SlackInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22.08 9C19.81 1.41 16.54-.35 9 1.92S-.35 7.46 1.92 15 7.46 24.35 15 22.08 24.35 16.54 22.08 9z"), SKPathAddMode.Append);
             source.MoveTo(12.57F,5.99F);
             source.LineTo(16.15F,16.39F);
             source.MoveTo(12.57F,5.99F);
             source.LineTo(16.15F,16.39F);
             source.MoveTo(7.85F,7.61F);
             source.LineTo(11.43F,18.01F);
             source.MoveTo(7.85F,7.61F);
             source.LineTo(11.43F,18.01F);
             source.MoveTo(16.39F,7.85F);
             source.LineTo(5.99F,11.43F);
             source.MoveTo(16.39F,7.85F);
             source.LineTo(5.99F,11.43F);
             source.MoveTo(18.01F,12.57F);
             source.LineTo(7.61F,16.15F);
             source.MoveTo(18.01F,12.57F);
             source.LineTo(7.61F,16.15F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Slack => SlackInstance.Value;
         private static Lazy<Icon> SlashInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(4.93F,4.93F);
             source.LineTo(19.07F,19.07F);
             source.MoveTo(4.93F,4.93F);
             source.LineTo(19.07F,19.07F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Slash => SlashInstance.Value;
         private static Lazy<Icon> SlidersInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(4,21);
             source.LineTo(4,14);
             source.MoveTo(4,21);
             source.LineTo(4,14);
             source.MoveTo(4,10);
             source.LineTo(4,3);
             source.MoveTo(4,10);
             source.LineTo(4,3);
             source.MoveTo(12,21);
             source.LineTo(12,12);
             source.MoveTo(12,21);
             source.LineTo(12,12);
             source.MoveTo(12,8);
             source.LineTo(12,3);
             source.MoveTo(12,8);
             source.LineTo(12,3);
             source.MoveTo(20,21);
             source.LineTo(20,16);
             source.MoveTo(20,21);
             source.LineTo(20,16);
             source.MoveTo(20,12);
             source.LineTo(20,3);
             source.MoveTo(20,12);
             source.LineTo(20,3);
             source.MoveTo(1,14);
             source.LineTo(7,14);
             source.MoveTo(1,14);
             source.LineTo(7,14);
             source.MoveTo(9,8);
             source.LineTo(15,8);
             source.MoveTo(9,8);
             source.LineTo(15,8);
             source.MoveTo(17,16);
             source.LineTo(23,16);
             source.MoveTo(17,16);
             source.LineTo(23,16);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Sliders => SlidersInstance.Value;
         private static Lazy<Icon> SmartphoneInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(5,2,14,20));
             source.MoveTo(12,18);
             source.LineTo(12,18);
             source.MoveTo(12,18);
             source.LineTo(12,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Smartphone => SmartphoneInstance.Value;
         private static Lazy<Icon> SpeakerInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(4,2,16,20));
             source.AddCircle(12,14,4);
             source.MoveTo(12,6);
             source.LineTo(12,6);
             source.MoveTo(12,6);
             source.LineTo(12,6);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Speaker => SpeakerInstance.Value;
         private static Lazy<Icon> SquareInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,3,18,18));
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Square => SquareInstance.Value;
         private static Lazy<Icon> StarInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12,2);
             source.AddPoly(new SKPoint [] { new SKPoint(12,2),new SKPoint(15.09F,8.26F),new SKPoint(22,9.27F),new SKPoint(17,14.14F),new SKPoint(18.18F,21.02F),new SKPoint(12,17.77F),new SKPoint(5.82F,21.02F),new SKPoint(7,14.14F),new SKPoint(2,9.27F),new SKPoint(8.91F,8.26F),new SKPoint(12,2),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Star => StarInstance.Value;
         private static Lazy<Icon> StopCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.AddRect(SKRect.Create(9,9,6,6));
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon StopCircle => StopCircleInstance.Value;
         private static Lazy<Icon> SunInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,5);
             source.MoveTo(12,1);
             source.LineTo(12,3);
             source.MoveTo(12,1);
             source.LineTo(12,3);
             source.MoveTo(12,21);
             source.LineTo(12,23);
             source.MoveTo(12,21);
             source.LineTo(12,23);
             source.MoveTo(4.22F,4.22F);
             source.LineTo(5.64F,5.64F);
             source.MoveTo(4.22F,4.22F);
             source.LineTo(5.64F,5.64F);
             source.MoveTo(18.36F,18.36F);
             source.LineTo(19.78F,19.78F);
             source.MoveTo(18.36F,18.36F);
             source.LineTo(19.78F,19.78F);
             source.MoveTo(1,12);
             source.LineTo(3,12);
             source.MoveTo(1,12);
             source.LineTo(3,12);
             source.MoveTo(21,12);
             source.LineTo(23,12);
             source.MoveTo(21,12);
             source.LineTo(23,12);
             source.MoveTo(4.22F,19.78F);
             source.LineTo(5.64F,18.36F);
             source.MoveTo(4.22F,19.78F);
             source.LineTo(5.64F,18.36F);
             source.MoveTo(18.36F,5.64F);
             source.LineTo(19.78F,4.22F);
             source.MoveTo(18.36F,5.64F);
             source.LineTo(19.78F,4.22F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Sun => SunInstance.Value;
         private static Lazy<Icon> SunriseInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M17 18a5 5 0 0 0-10 0"), SKPathAddMode.Append);
             source.MoveTo(12,2);
             source.LineTo(12,9);
             source.MoveTo(12,2);
             source.LineTo(12,9);
             source.MoveTo(4.22F,10.22F);
             source.LineTo(5.64F,11.64F);
             source.MoveTo(4.22F,10.22F);
             source.LineTo(5.64F,11.64F);
             source.MoveTo(1,18);
             source.LineTo(3,18);
             source.MoveTo(1,18);
             source.LineTo(3,18);
             source.MoveTo(21,18);
             source.LineTo(23,18);
             source.MoveTo(21,18);
             source.LineTo(23,18);
             source.MoveTo(18.36F,11.64F);
             source.LineTo(19.78F,10.22F);
             source.MoveTo(18.36F,11.64F);
             source.LineTo(19.78F,10.22F);
             source.MoveTo(23,22);
             source.LineTo(1,22);
             source.MoveTo(23,22);
             source.LineTo(1,22);
             source.MoveTo(8,6);
             source.AddPoly(new SKPoint [] { new SKPoint(8,6),new SKPoint(12,2),new SKPoint(16,6),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Sunrise => SunriseInstance.Value;
         private static Lazy<Icon> SunsetInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M17 18a5 5 0 0 0-10 0"), SKPathAddMode.Append);
             source.MoveTo(12,9);
             source.LineTo(12,2);
             source.MoveTo(12,9);
             source.LineTo(12,2);
             source.MoveTo(4.22F,10.22F);
             source.LineTo(5.64F,11.64F);
             source.MoveTo(4.22F,10.22F);
             source.LineTo(5.64F,11.64F);
             source.MoveTo(1,18);
             source.LineTo(3,18);
             source.MoveTo(1,18);
             source.LineTo(3,18);
             source.MoveTo(21,18);
             source.LineTo(23,18);
             source.MoveTo(21,18);
             source.LineTo(23,18);
             source.MoveTo(18.36F,11.64F);
             source.LineTo(19.78F,10.22F);
             source.MoveTo(18.36F,11.64F);
             source.LineTo(19.78F,10.22F);
             source.MoveTo(23,22);
             source.LineTo(1,22);
             source.MoveTo(23,22);
             source.LineTo(1,22);
             source.MoveTo(16,5);
             source.AddPoly(new SKPoint [] { new SKPoint(16,5),new SKPoint(12,9),new SKPoint(8,5),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Sunset => SunsetInstance.Value;
         private static Lazy<Icon> TabletInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(4,2,16,20));
             source.MoveTo(12,18);
             source.LineTo(12,18);
             source.MoveTo(12,18);
             source.LineTo(12,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Tablet => TabletInstance.Value;
         private static Lazy<Icon> TagInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M20.59 13.41l-7.17 7.17a2 2 0 0 1-2.83 0L2 12V2h10l8.59 8.59a2 2 0 0 1 0 2.82z"), SKPathAddMode.Append);
             source.MoveTo(7,7);
             source.LineTo(7,7);
             source.MoveTo(7,7);
             source.LineTo(7,7);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Tag => TagInstance.Value;
         private static Lazy<Icon> TargetInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.AddCircle(12,12,6);
             source.AddCircle(12,12,2);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Target => TargetInstance.Value;
         private static Lazy<Icon> TerminalInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(4,17);
             source.AddPoly(new SKPoint [] { new SKPoint(4,17),new SKPoint(10,11),new SKPoint(4,5),},false);
             source.MoveTo(12,19);
             source.LineTo(20,19);
             source.MoveTo(12,19);
             source.LineTo(20,19);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Terminal => TerminalInstance.Value;
         private static Lazy<Icon> ThermometerInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M14 14.76V3.5a2.5 2.5 0 0 0-5 0v11.26a4.5 4.5 0 1 0 5 0z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Thermometer => ThermometerInstance.Value;
         private static Lazy<Icon> ThumbsDownInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M10 15v4a3 3 0 0 0 3 3l4-9V2H5.72a2 2 0 0 0-2 1.7l-1.38 9a2 2 0 0 0 2 2.3zm7-13h2.67A2.31 2.31 0 0 1 22 4v7a2.31 2.31 0 0 1-2.33 2H17"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ThumbsDown => ThumbsDownInstance.Value;
         private static Lazy<Icon> ThumbsUpInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M14 9V5a3 3 0 0 0-3-3l-4 9v11h11.28a2 2 0 0 0 2-1.7l1.38-9a2 2 0 0 0-2-2.3zM7 22H4a2 2 0 0 1-2-2v-7a2 2 0 0 1 2-2h3"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ThumbsUp => ThumbsUpInstance.Value;
         private static Lazy<Icon> ToggleLeftInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(1,5,22,14));
             source.AddCircle(8,12,3);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ToggleLeft => ToggleLeftInstance.Value;
         private static Lazy<Icon> ToggleRightInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(1,5,22,14));
             source.AddCircle(16,12,3);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ToggleRight => ToggleRightInstance.Value;
         private static Lazy<Icon> Trash2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(3,6);
             source.AddPoly(new SKPoint [] { new SKPoint(3,6),new SKPoint(5,6),new SKPoint(21,6),},false);
             source.AddPath(SKPath.ParseSvgPathData("M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2"), SKPathAddMode.Append);
             source.MoveTo(10,11);
             source.LineTo(10,17);
             source.MoveTo(10,11);
             source.LineTo(10,17);
             source.MoveTo(14,11);
             source.LineTo(14,17);
             source.MoveTo(14,11);
             source.LineTo(14,17);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Trash2 => Trash2Instance.Value;
         private static Lazy<Icon> TrashInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(3,6);
             source.AddPoly(new SKPoint [] { new SKPoint(3,6),new SKPoint(5,6),new SKPoint(21,6),},false);
             source.AddPath(SKPath.ParseSvgPathData("M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Trash => TrashInstance.Value;
         private static Lazy<Icon> TrendingDownInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(23,18);
             source.AddPoly(new SKPoint [] { new SKPoint(23,18),new SKPoint(13.5F,8.5F),new SKPoint(8.5F,13.5F),new SKPoint(1,6),},false);
             source.MoveTo(17,18);
             source.AddPoly(new SKPoint [] { new SKPoint(17,18),new SKPoint(23,18),new SKPoint(23,12),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon TrendingDown => TrendingDownInstance.Value;
         private static Lazy<Icon> TrendingUpInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(23,6);
             source.AddPoly(new SKPoint [] { new SKPoint(23,6),new SKPoint(13.5F,15.5F),new SKPoint(8.5F,10.5F),new SKPoint(1,18),},false);
             source.MoveTo(17,6);
             source.AddPoly(new SKPoint [] { new SKPoint(17,6),new SKPoint(23,6),new SKPoint(23,12),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon TrendingUp => TrendingUpInstance.Value;
         private static Lazy<Icon> TriangleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M10.29 3.86L1.82 18a2 2 0 0 0 1.71 3h16.94a2 2 0 0 0 1.71-3L13.71 3.86a2 2 0 0 0-3.42 0z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Triangle => TriangleInstance.Value;
         private static Lazy<Icon> TruckInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(1,3,15,13));
             source.MoveTo(16,8);
             source.AddPoly(new SKPoint [] { new SKPoint(16,8),new SKPoint(20,8),new SKPoint(23,11),new SKPoint(23,16),new SKPoint(16,16),new SKPoint(16,8),},true);
             source.AddCircle(5.5F,18.5F,2.5F);
             source.AddCircle(18.5F,18.5F,2.5F);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Truck => TruckInstance.Value;
         private static Lazy<Icon> TvInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(2,7,20,15));
             source.MoveTo(17,2);
             source.AddPoly(new SKPoint [] { new SKPoint(17,2),new SKPoint(12,7),new SKPoint(7,2),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Tv => TvInstance.Value;
         private static Lazy<Icon> TwitterInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M23 3a10.9 10.9 0 0 1-3.14 1.53 4.48 4.48 0 0 0-7.86 3v1A10.66 10.66 0 0 1 3 4s-4 9 5 13a11.64 11.64 0 0 1-7 2c9 5 20 0 20-11.5a4.5 4.5 0 0 0-.08-.83A7.72 7.72 0 0 0 23 3z"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Twitter => TwitterInstance.Value;
         private static Lazy<Icon> TypeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(4,7);
             source.AddPoly(new SKPoint [] { new SKPoint(4,7),new SKPoint(4,4),new SKPoint(20,4),new SKPoint(20,7),},false);
             source.MoveTo(9,20);
             source.LineTo(15,20);
             source.MoveTo(9,20);
             source.LineTo(15,20);
             source.MoveTo(12,4);
             source.LineTo(12,20);
             source.MoveTo(12,4);
             source.LineTo(12,20);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Type => TypeInstance.Value;
         private static Lazy<Icon> UmbrellaInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M23 12a11.05 11.05 0 0 0-22 0zm-5 7a3 3 0 0 1-6 0v-7"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Umbrella => UmbrellaInstance.Value;
         private static Lazy<Icon> UnderlineInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M6 3v7a6 6 0 0 0 6 6 6 6 0 0 0 6-6V3"), SKPathAddMode.Append);
             source.MoveTo(4,21);
             source.LineTo(20,21);
             source.MoveTo(4,21);
             source.LineTo(20,21);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Underline => UnderlineInstance.Value;
         private static Lazy<Icon> UnlockInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,11,18,11));
             source.AddPath(SKPath.ParseSvgPathData("M7 11V7a5 5 0 0 1 9.9-1"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Unlock => UnlockInstance.Value;
         private static Lazy<Icon> UploadCloudInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(16,16);
             source.AddPoly(new SKPoint [] { new SKPoint(16,16),new SKPoint(12,12),new SKPoint(8,16),},false);
             source.MoveTo(12,12);
             source.LineTo(12,21);
             source.MoveTo(12,12);
             source.LineTo(12,21);
             source.AddPath(SKPath.ParseSvgPathData("M20.39 18.39A5 5 0 0 0 18 9h-1.26A8 8 0 1 0 3 16.3"), SKPathAddMode.Append);
             source.MoveTo(16,16);
             source.AddPoly(new SKPoint [] { new SKPoint(16,16),new SKPoint(12,12),new SKPoint(8,16),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon UploadCloud => UploadCloudInstance.Value;
         private static Lazy<Icon> UploadInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M21 15v4a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2v-4"), SKPathAddMode.Append);
             source.MoveTo(17,8);
             source.AddPoly(new SKPoint [] { new SKPoint(17,8),new SKPoint(12,3),new SKPoint(7,8),},false);
             source.MoveTo(12,3);
             source.LineTo(12,15);
             source.MoveTo(12,3);
             source.LineTo(12,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Upload => UploadInstance.Value;
         private static Lazy<Icon> UserCheckInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M16 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2"), SKPathAddMode.Append);
             source.AddCircle(8.5F,7,4);
             source.MoveTo(17,11);
             source.AddPoly(new SKPoint [] { new SKPoint(17,11),new SKPoint(19,13),new SKPoint(23,9),},false);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon UserCheck => UserCheckInstance.Value;
         private static Lazy<Icon> UserMinusInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M16 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2"), SKPathAddMode.Append);
             source.AddCircle(8.5F,7,4);
             source.MoveTo(23,11);
             source.LineTo(17,11);
             source.MoveTo(23,11);
             source.LineTo(17,11);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon UserMinus => UserMinusInstance.Value;
         private static Lazy<Icon> UserPlusInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M16 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2"), SKPathAddMode.Append);
             source.AddCircle(8.5F,7,4);
             source.MoveTo(20,8);
             source.LineTo(20,14);
             source.MoveTo(20,8);
             source.LineTo(20,14);
             source.MoveTo(23,11);
             source.LineTo(17,11);
             source.MoveTo(23,11);
             source.LineTo(17,11);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon UserPlus => UserPlusInstance.Value;
         private static Lazy<Icon> UserXInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M16 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2"), SKPathAddMode.Append);
             source.AddCircle(8.5F,7,4);
             source.MoveTo(18,8);
             source.LineTo(23,13);
             source.MoveTo(18,8);
             source.LineTo(23,13);
             source.MoveTo(23,8);
             source.LineTo(18,13);
             source.MoveTo(23,8);
             source.LineTo(18,13);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon UserX => UserXInstance.Value;
         private static Lazy<Icon> UserInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2"), SKPathAddMode.Append);
             source.AddCircle(12,7,4);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon User => UserInstance.Value;
         private static Lazy<Icon> UsersInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M17 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2"), SKPathAddMode.Append);
             source.AddCircle(9,7,4);
             source.AddPath(SKPath.ParseSvgPathData("M23 21v-2a4 4 0 0 0-3-3.87"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M16 3.13a4 4 0 0 1 0 7.75"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Users => UsersInstance.Value;
         private static Lazy<Icon> VideoOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M16 16v1a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2V7a2 2 0 0 1 2-2h2m5.66 0H14a2 2 0 0 1 2 2v3.34l1 1L23 7v10"), SKPathAddMode.Append);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon VideoOff => VideoOffInstance.Value;
         private static Lazy<Icon> VideoInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(23,7);
             source.AddPoly(new SKPoint [] { new SKPoint(23,7),new SKPoint(16,12),new SKPoint(23,17),new SKPoint(23,7),},true);
             source.AddRect(SKRect.Create(1,5,15,14));
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Video => VideoInstance.Value;
         private static Lazy<Icon> VoicemailInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(5.5F,11.5F,4.5F);
             source.AddCircle(18.5F,11.5F,4.5F);
             source.MoveTo(5.5F,16);
             source.LineTo(18.5F,16);
             source.MoveTo(5.5F,16);
             source.LineTo(18.5F,16);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Voicemail => VoicemailInstance.Value;
         private static Lazy<Icon> Volume1Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(11,5);
             source.AddPoly(new SKPoint [] { new SKPoint(11,5),new SKPoint(6,9),new SKPoint(2,9),new SKPoint(2,15),new SKPoint(6,15),new SKPoint(11,19),new SKPoint(11,5),},true);
             source.AddPath(SKPath.ParseSvgPathData("M15.54 8.46a5 5 0 0 1 0 7.07"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Volume1 => Volume1Instance.Value;
         private static Lazy<Icon> Volume2Instance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(11,5);
             source.AddPoly(new SKPoint [] { new SKPoint(11,5),new SKPoint(6,9),new SKPoint(2,9),new SKPoint(2,15),new SKPoint(6,15),new SKPoint(11,19),new SKPoint(11,5),},true);
             source.AddPath(SKPath.ParseSvgPathData("M19.07 4.93a10 10 0 0 1 0 14.14M15.54 8.46a5 5 0 0 1 0 7.07"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Volume2 => Volume2Instance.Value;
         private static Lazy<Icon> VolumeXInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(11,5);
             source.AddPoly(new SKPoint [] { new SKPoint(11,5),new SKPoint(6,9),new SKPoint(2,9),new SKPoint(2,15),new SKPoint(6,15),new SKPoint(11,19),new SKPoint(11,5),},true);
             source.MoveTo(23,9);
             source.LineTo(17,15);
             source.MoveTo(23,9);
             source.LineTo(17,15);
             source.MoveTo(17,9);
             source.LineTo(23,15);
             source.MoveTo(17,9);
             source.LineTo(23,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon VolumeX => VolumeXInstance.Value;
         private static Lazy<Icon> VolumeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(11,5);
             source.AddPoly(new SKPoint [] { new SKPoint(11,5),new SKPoint(6,9),new SKPoint(2,9),new SKPoint(2,15),new SKPoint(6,15),new SKPoint(11,19),new SKPoint(11,5),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Volume => VolumeInstance.Value;
         private static Lazy<Icon> WatchInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,7);
             source.MoveTo(12,9);
             source.AddPoly(new SKPoint [] { new SKPoint(12,9),new SKPoint(12,12),new SKPoint(13.5F,13.5F),},false);
             source.AddPath(SKPath.ParseSvgPathData("M16.51 17.35l-.35 3.83a2 2 0 0 1-2 1.82H9.83a2 2 0 0 1-2-1.82l-.35-3.83m.01-10.7l.35-3.83A2 2 0 0 1 9.83 1h4.35a2 2 0 0 1 2 1.82l.35 3.83"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Watch => WatchInstance.Value;
         private static Lazy<Icon> WifiOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.AddPath(SKPath.ParseSvgPathData("M16.72 11.06A10.94 10.94 0 0 1 19 12.55"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M5 12.55a10.94 10.94 0 0 1 5.17-2.39"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M10.71 5.05A16 16 0 0 1 22.58 9"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M1.42 9a15.91 15.91 0 0 1 4.7-2.88"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M8.53 16.11a6 6 0 0 1 6.95 0"), SKPathAddMode.Append);
             source.MoveTo(12,20);
             source.LineTo(12,20);
             source.MoveTo(12,20);
             source.LineTo(12,20);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon WifiOff => WifiOffInstance.Value;
         private static Lazy<Icon> WifiInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M5 12.55a11 11 0 0 1 14.08 0"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M1.42 9a16 16 0 0 1 21.16 0"), SKPathAddMode.Append);
             source.AddPath(SKPath.ParseSvgPathData("M8.53 16.11a6 6 0 0 1 6.95 0"), SKPathAddMode.Append);
             source.MoveTo(12,20);
             source.LineTo(12,20);
             source.MoveTo(12,20);
             source.LineTo(12,20);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Wifi => WifiInstance.Value;
         private static Lazy<Icon> WindInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M9.59 4.59A2 2 0 1 1 11 8H2m10.59 11.41A2 2 0 1 0 14 16H2m15.73-8.27A2.5 2.5 0 1 1 19.5 12H2"), SKPathAddMode.Append);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Wind => WindInstance.Value;
         private static Lazy<Icon> XCircleInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(12,12,10);
             source.MoveTo(15,9);
             source.LineTo(9,15);
             source.MoveTo(15,9);
             source.LineTo(9,15);
             source.MoveTo(9,9);
             source.LineTo(15,15);
             source.MoveTo(9,9);
             source.LineTo(15,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon XCircle => XCircleInstance.Value;
         private static Lazy<Icon> XSquareInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddRect(SKRect.Create(3,3,18,18));
             source.MoveTo(9,9);
             source.LineTo(15,15);
             source.MoveTo(9,9);
             source.LineTo(15,15);
             source.MoveTo(15,9);
             source.LineTo(9,15);
             source.MoveTo(15,9);
             source.LineTo(9,15);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon XSquare => XSquareInstance.Value;
         private static Lazy<Icon> XInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(18,6);
             source.LineTo(6,18);
             source.MoveTo(18,6);
             source.LineTo(6,18);
             source.MoveTo(6,6);
             source.LineTo(18,18);
             source.MoveTo(6,6);
             source.LineTo(18,18);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon X => XInstance.Value;
         private static Lazy<Icon> YoutubeInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddPath(SKPath.ParseSvgPathData("M22.54 6.42a2.78 2.78 0 0 0-1.94-2C18.88 4 12 4 12 4s-6.88 0-8.6.46a2.78 2.78 0 0 0-1.94 2A29 29 0 0 0 1 11.75a29 29 0 0 0 .46 5.33A2.78 2.78 0 0 0 3.4 19c1.72.46 8.6.46 8.6.46s6.88 0 8.6-.46a2.78 2.78 0 0 0 1.94-2 29 29 0 0 0 .46-5.25 29 29 0 0 0-.46-5.33z"), SKPathAddMode.Append);
             source.MoveTo(9.75F,15.02F);
             source.AddPoly(new SKPoint [] { new SKPoint(9.75F,15.02F),new SKPoint(15.5F,11.75F),new SKPoint(9.75F,8.48F),new SKPoint(9.75F,15.02F),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Youtube => YoutubeInstance.Value;
         private static Lazy<Icon> ZapOffInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(12.41F,6.75F);
             source.AddPoly(new SKPoint [] { new SKPoint(12.41F,6.75F),new SKPoint(13,2),new SKPoint(10.57F,4.92F),},false);
             source.MoveTo(18.57F,12.91F);
             source.AddPoly(new SKPoint [] { new SKPoint(18.57F,12.91F),new SKPoint(21,10),new SKPoint(15.66F,10),},false);
             source.MoveTo(8,8);
             source.AddPoly(new SKPoint [] { new SKPoint(8,8),new SKPoint(3,14),new SKPoint(12,14),new SKPoint(11,22),new SKPoint(16,16),},false);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             source.MoveTo(1,1);
             source.LineTo(23,23);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ZapOff => ZapOffInstance.Value;
         private static Lazy<Icon> ZapInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.MoveTo(13,2);
             source.AddPoly(new SKPoint [] { new SKPoint(13,2),new SKPoint(3,14),new SKPoint(12,14),new SKPoint(11,22),new SKPoint(21,10),new SKPoint(12,10),new SKPoint(13,2),},true);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon Zap => ZapInstance.Value;
         private static Lazy<Icon> ZoomInInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(11,11,8);
             source.MoveTo(21,21);
             source.LineTo(16.65F,16.65F);
             source.MoveTo(21,21);
             source.LineTo(16.65F,16.65F);
             source.MoveTo(11,8);
             source.LineTo(11,14);
             source.MoveTo(11,8);
             source.LineTo(11,14);
             source.MoveTo(8,11);
             source.LineTo(14,11);
             source.MoveTo(8,11);
             source.LineTo(14,11);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ZoomIn => ZoomInInstance.Value;
         private static Lazy<Icon> ZoomOutInstance = new Lazy<Icon>(() =>
         {
             var source = new SKPath();
             source.AddCircle(11,11,8);
             source.MoveTo(21,21);
             source.LineTo(16.65F,16.65F);
             source.MoveTo(21,21);
             source.LineTo(16.65F,16.65F);
             source.MoveTo(8,11);
             source.LineTo(14,11);
             source.MoveTo(8,11);
             source.LineTo(14,11);
             return new Icon(source, SKStrokeCap.Round, SKStrokeJoin.Round);
         });

         public static Icon ZoomOut => ZoomOutInstance.Value;
    }
}
