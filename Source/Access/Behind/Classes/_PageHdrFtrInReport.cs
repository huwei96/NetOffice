﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.AccessApi.Behind
{
	/// <summary>
	/// CoClass _PageHdrFtrInReport
	/// SupportByVersion Access, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Access", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
    [ComEventContract(typeof(NetOffice.AccessApi.EventContracts._PageHdrFtrInReportEvents), typeof(NetOffice.AccessApi.EventContracts.DispPageHdrFtrInReportEvents))]
    public class _PageHdrFtrInReport : _Section, NetOffice.AccessApi._PageHdrFtrInReport
    {
		#pragma warning disable

		#region Fields

		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;
        private NetOffice.AccessApi.Behind.EventContracts._PageHdrFtrInReportEvents_SinkHelper __PageHdrFtrInReportEvents_SinkHelper;
		private NetOffice.AccessApi.Behind.EventContracts.DispPageHdrFtrInReportEvents_SinkHelper _dispPageHdrFtrInReportEvents_SinkHelper;

		#endregion

		#region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_PageHdrFtrInReport);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _PageHdrFtrInReport() : base()
		{

		}

		#endregion

		#region Static CoClass Methods
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15,16
		/// </summary>
		private event _PageHdrFtrInReport_FormatEventHandler _FormatEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual event _PageHdrFtrInReport_FormatEventHandler FormatEvent
		{
			add
			{
				CreateEventBridge();
				_FormatEvent += value;
			}
			remove
			{
				_FormatEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15,16
		/// </summary>
		private event _PageHdrFtrInReport_PrintEventHandler _PrintEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual event _PageHdrFtrInReport_PrintEventHandler PrintEvent
		{
			add
			{
				CreateEventBridge();
				_PrintEvent += value;
			}
			remove
			{
				_PrintEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15,16
		/// </summary>
		private event _PageHdrFtrInReport_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual event _PageHdrFtrInReport_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15,16
		/// </summary>
		private event _PageHdrFtrInReport_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual event _PageHdrFtrInReport_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15,16
		/// </summary>
		private event _PageHdrFtrInReport_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual event _PageHdrFtrInReport_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15,16
		/// </summary>
		private event _PageHdrFtrInReport_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual event _PageHdrFtrInReport_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15,16
		/// </summary>
		private event _PageHdrFtrInReport_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual event _PageHdrFtrInReport_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15,16
		/// </summary>
		private event _PageHdrFtrInReport_PaintEventHandler _PaintEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual event _PageHdrFtrInReport_PaintEventHandler PaintEvent
		{
			add
			{
				CreateEventBridge();
				_PaintEvent += value;
			}
			remove
			{
				_PaintEvent -= value;
			}
		}

		#endregion

	    #region IEventBinding

		/// <summary>
        /// Creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual void CreateEventBridge()
        {
			if(false == Factory.Settings.EnableEvents)
				return;

			if (null != _connectPoint)
				return;

            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, NetOffice.AccessApi.Behind.EventContracts._PageHdrFtrInReportEvents_SinkHelper.Id, NetOffice.AccessApi.Behind.EventContracts.DispPageHdrFtrInReportEvents_SinkHelper.Id);


			if(NetOffice.AccessApi.Behind.EventContracts._PageHdrFtrInReportEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__PageHdrFtrInReportEvents_SinkHelper = new NetOffice.AccessApi.Behind.EventContracts._PageHdrFtrInReportEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(NetOffice.AccessApi.Behind.EventContracts.DispPageHdrFtrInReportEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispPageHdrFtrInReportEvents_SinkHelper = new NetOffice.AccessApi.Behind.EventContracts.DispPageHdrFtrInReportEvents_SinkHelper(this, _connectPoint);
				return;
			}
        }

        /// <summary>
        /// The instance use currently an event listener
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool EventBridgeInitialized
        {
            get
            {
                return (null != _connectPoint);
            }
        }
        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <returns>true if one or more event is active, otherwise false</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool HasEventRecipients()
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType);
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool HasEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Target methods from its actual event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual Delegate[] GetEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Returns the current count of event recipients
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual int GetCountOfEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetCountOfEventRecipients(this, LateBindingApiWrapperType, eventName);
         }

        /// <summary>
        /// Raise an instance event
        /// </summary>
        /// <param name="eventName">name of the event without 'Event' at the end</param>
        /// <param name="paramsArray">custom arguments for the event</param>
        /// <returns>count of called event recipients</returns>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
            return NetOffice.Events.CoClassEventReflector.RaiseCustomEvent(this, LateBindingApiWrapperType, eventName, ref paramsArray);
		}
        /// <summary>
        /// Stop listening events for the instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual void DisposeEventBridge()
        {
			if( null != __PageHdrFtrInReportEvents_SinkHelper)
			{
				__PageHdrFtrInReportEvents_SinkHelper.Dispose();
				__PageHdrFtrInReportEvents_SinkHelper = null;
			}
			if( null != _dispPageHdrFtrInReportEvents_SinkHelper)
			{
				_dispPageHdrFtrInReportEvents_SinkHelper.Dispose();
				_dispPageHdrFtrInReportEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}

        #endregion

		#pragma warning restore
	}
}
