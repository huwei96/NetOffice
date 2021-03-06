﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Exceptions;
using NetOffice.Attributes;

namespace NetOffice.ExcelApi.Behind.EventContracts
{
    /// <summary>
    /// Default implementation of <see cref="NetOffice.ExcelApi.EventContracts.ChartEvents"/>
    /// </summary>
    [InternalEntity(InternalEntityKind.SinkHelper)]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
    public class ChartEvents_SinkHelper : SinkHelper, NetOffice.ExcelApi.EventContracts.ChartEvents
    {
        #region Static

        /// <summary>
        /// Interface Id from ChartEvents
        /// </summary>
        public static readonly string Id = "0002440F-0000-0000-C000-000000000046";

        #endregion

        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="eventClass"></param>
        /// <param name="connectPoint"></param>
        /// <exception cref="NetOfficeCOMException">Unexpected error</exception>
        public ChartEvents_SinkHelper(ICOMObject eventClass, IConnectionPoint connectPoint) : base(eventClass)
        {
            SetupEventBinding(connectPoint);
        }

        #endregion

        #region ChartEvents

        /// <summary>
        /// 
        /// </summary>
        public void Activate()
        {
            if (!Validate("Activate"))
            {
                return;
            }

            object[] paramsArray = new object[0];
            EventBinding.RaiseCustomEvent("Activate", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Deactivate()
        {
            if (!Validate("Deactivate"))
            {
                return;
            }

            object[] paramsArray = new object[0];
            EventBinding.RaiseCustomEvent("Deactivate", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Resize()
        {
            if (!Validate("Resize"))
            {
                return;
            }

            object[] paramsArray = new object[0];
            EventBinding.RaiseCustomEvent("Resize", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y)
        {
            if (!Validate("MouseDown"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

            Int32 newButton = ToInt32(button);
            Int32 newShift = ToInt32(shift);
            Int32 newx = ToInt32(x);
            Int32 newy = ToInt32(y);
            object[] paramsArray = new object[4];
            paramsArray[0] = newButton;
            paramsArray[1] = newShift;
            paramsArray[2] = newx;
            paramsArray[3] = newy;
            EventBinding.RaiseCustomEvent("MouseDown", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y)
        {
            if (!Validate("MouseUp"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

            Int32 newButton = ToInt32(button);
            Int32 newShift = ToInt32(shift);
            Int32 newx = ToInt32(x);
            Int32 newy = ToInt32(y);
            object[] paramsArray = new object[4];
            paramsArray[0] = newButton;
            paramsArray[1] = newShift;
            paramsArray[2] = newx;
            paramsArray[3] = newy;
            EventBinding.RaiseCustomEvent("MouseUp", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y)
        {
            if (!Validate("MouseMove"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

            Int32 newButton = ToInt32(button);
            Int32 newShift = ToInt32(shift);
            Int32 newx = ToInt32(x);
            Int32 newy = ToInt32(y);
            object[] paramsArray = new object[4];
            paramsArray[0] = newButton;
            paramsArray[1] = newShift;
            paramsArray[2] = newx;
            paramsArray[3] = newy;
            EventBinding.RaiseCustomEvent("MouseMove", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancel"></param>
        public void BeforeRightClick([In] [Out] ref object cancel)
        {
            if (!Validate("BeforeRightClick"))
            {
                Invoker.ReleaseParamsArray(cancel);
                return;
            }

            object[] paramsArray = new object[1];
            paramsArray.SetValue(cancel, 0);
            EventBinding.RaiseCustomEvent("BeforeRightClick", ref paramsArray);

            cancel = ToBoolean(paramsArray[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DragPlot()
        {
            if (!Validate("DragPlot"))
            {
                return;
            }

            object[] paramsArray = new object[0];
            EventBinding.RaiseCustomEvent("DragPlot", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DragOver()
        {
            if (!Validate("DragOver"))
            {
                return;
            }

            object[] paramsArray = new object[0];
            EventBinding.RaiseCustomEvent("DragOver", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementID"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <param name="cancel"></param>
        public void BeforeDoubleClick([In] object elementID, [In] object arg1, [In] object arg2, [In] [Out] ref object cancel)
        {
            if (!Validate("BeforeDoubleClick"))
            {
                Invoker.ReleaseParamsArray(elementID, arg1, arg2, cancel);
                return;
            }

            Int32 newElementID = ToInt32(elementID);
            Int32 newArg1 = ToInt32(arg1);
            Int32 newArg2 = ToInt32(arg2);
            object[] paramsArray = new object[4];
            paramsArray[0] = newElementID;
            paramsArray[1] = newArg1;
            paramsArray[2] = newArg2;
            paramsArray.SetValue(cancel, 3);
            EventBinding.RaiseCustomEvent("BeforeDoubleClick", ref paramsArray);

            cancel = ToBoolean(paramsArray[3]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementID"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        public void Select([In] object elementID, [In] object arg1, [In] object arg2)
        {
            if (!Validate("Select"))
            {
                Invoker.ReleaseParamsArray(elementID, arg1, arg2);
                return;
            }

            Int32 newElementID = ToInt32(elementID);
            Int32 newArg1 = ToInt32(arg1);
            Int32 newArg2 = ToInt32(arg2);
            object[] paramsArray = new object[3];
            paramsArray[0] = newElementID;
            paramsArray[1] = newArg1;
            paramsArray[2] = newArg2;
            EventBinding.RaiseCustomEvent("Select", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seriesIndex"></param>
        /// <param name="pointIndex"></param>
        public void SeriesChange([In] object seriesIndex, [In] object pointIndex)
        {
            if (!Validate("SeriesChange"))
            {
                Invoker.ReleaseParamsArray(seriesIndex, pointIndex);
                return;
            }

            Int32 newSeriesIndex = ToInt32(seriesIndex);
            Int32 newPointIndex = ToInt32(pointIndex);
            object[] paramsArray = new object[2];
            paramsArray[0] = newSeriesIndex;
            paramsArray[1] = newPointIndex;
            EventBinding.RaiseCustomEvent("SeriesChange", ref paramsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Calculate()
        {
            if (!Validate("Calculate"))
            {
                return;
            }

            object[] paramsArray = new object[0];
            EventBinding.RaiseCustomEvent("Calculate", ref paramsArray);
        }

        #endregion
    }
}
