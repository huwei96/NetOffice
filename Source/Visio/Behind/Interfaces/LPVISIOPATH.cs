﻿using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.VisioApi;

namespace NetOffice.VisioApi.Behind
{
	/// <summary>
	/// Interface LPVISIOPATH 
	/// SupportByVersion Visio, 11,12,14,15,16
	/// </summary>	[SupportByVersion("Visio", 11,12,14,15,16)]
	[EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "Item")]
	public class LPVISIOPATH : COMObject, NetOffice.VisioApi.LPVISIOPATH
	{
		#pragma warning disable

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

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(LPVISIOPATH);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public LPVISIOPATH() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[BaseResult]
		public virtual NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.VisioApi.IVApplication>(this, "Application");
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public virtual Int16 ObjectType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "ObjectType");
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">Int16 index</param>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual NetOffice.VisioApi.IVCurve get_Item16(Int16 index)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.VisioApi.IVCurve>(this, "Item16", typeof(NetOffice.VisioApi.IVCurve), index);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Alias for get_Item16
		/// </summary>
		/// <param name="index">Int16 index</param>
		[SupportByVersion("Visio", 11,12,14,15,16), Redirect("get_Item16")]
		public virtual NetOffice.VisioApi.IVCurve Item16(Int16 index)
		{
			return get_Item16(index);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual Int16 Count16
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "Count16");
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public virtual Int16 Closed
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "Closed");
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[BaseResult]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.VisioApi.IVCurve this[Int32 index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.VisioApi.IVCurve>(this, "Item", index);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="tolerance">Double tolerance</param>
		/// <param name="xyArray">Double[] xyArray</param>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public virtual void Points(Double tolerance, out Double[] xyArray)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			xyArray = null;
			object[] paramsArray = Invoker.ValidateParamsArray(tolerance, (object)xyArray);
			Invoker.Method(this, "Points", paramsArray, modifiers);
			xyArray = (Double[])paramsArray[1];
		}

        #endregion

        #region IEnumerable<NetOffice.VisioApi.IVCurve> Member

        /// <summary>
        /// SupportByVersion Visio, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Visio", 11, 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.VisioApi.IVCurve> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.VisioApi.IVCurve item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable Members

        /// <summary>
        /// SupportByVersion Visio, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Visio", 11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

