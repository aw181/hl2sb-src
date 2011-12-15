// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientConfigStoreVTable
	{
		public IntPtr IsSet0;
		public IntPtr GetBool1;
		public IntPtr GetInt2;
		public IntPtr GetUint643;
		public IntPtr GetFloat4;
		public IntPtr GetString5;
		public IntPtr GetBinary6;
		public IntPtr GetBinaryWatermarked7;
		public IntPtr SetBool8;
		public IntPtr SetInt9;
		public IntPtr SetUint6410;
		public IntPtr SetFloat11;
		public IntPtr SetString12;
		public IntPtr SetBinary13;
		public IntPtr SetBinaryWatermarked14;
		public IntPtr RemoveKey15;
		public IntPtr GetKeySerialized16;
		public IntPtr FlushToDisk17;
		private IntPtr DTorIClientConfigStore18;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTCONFIGSTORE_INTERFACE_VERSION001")]
	public class IClientConfigStore : InteropHelp.NativeWrapper<IClientConfigStoreVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsSetES( IntPtr thisptr, EConfigStore eConfigStore, string keyName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsSet( EConfigStore eConfigStore, string keyName ) 
		{
			return this.GetFunction<NativeIsSetES>( this.Functions.IsSet0 )( this.ObjectAddress, eConfigStore, keyName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetBoolESB( IntPtr thisptr, EConfigStore eConfigStore, string keyName, [MarshalAs(UnmanagedType.I1)] bool defaultValue );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetBool( EConfigStore eConfigStore, string keyName, bool defaultValue ) 
		{
			return this.GetFunction<NativeGetBoolESB>( this.Functions.GetBool1 )( this.ObjectAddress, eConfigStore, keyName, defaultValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetIntESI( IntPtr thisptr, EConfigStore eConfigStore, string keyName, Int32 defaultValue );
		public Int32 GetInt( EConfigStore eConfigStore, string keyName, Int32 defaultValue ) 
		{
			return this.GetFunction<NativeGetIntESI>( this.Functions.GetInt2 )( this.ObjectAddress, eConfigStore, keyName, defaultValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetUint64ESU( IntPtr thisptr, ref UInt64 retarg, EConfigStore eConfigStore, string keyName, UInt64 defaultValue );
		public UInt64 GetUint64( EConfigStore eConfigStore, string keyName, UInt64 defaultValue ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetUint64ESU>( this.Functions.GetUint643 )( this.ObjectAddress, ref ret, eConfigStore, keyName, defaultValue ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate float NativeGetFloatESF( IntPtr thisptr, EConfigStore eConfigStore, string keyName, float defaultValue );
		public float GetFloat( EConfigStore eConfigStore, string keyName, float defaultValue ) 
		{
			return this.GetFunction<NativeGetFloatESF>( this.Functions.GetFloat4 )( this.ObjectAddress, eConfigStore, keyName, defaultValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetStringESS( IntPtr thisptr, EConfigStore eConfigStore, string keyName, string defaultValue );
		public string GetString( EConfigStore eConfigStore, string keyName, string defaultValue ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetStringESS>( this.Functions.GetString5 )( this.ObjectAddress, eConfigStore, keyName, defaultValue ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetBinaryESBU( IntPtr thisptr, EConfigStore eConfigStore, string keyName, Byte[] pBuffer, UInt32 uSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetBinary( EConfigStore eConfigStore, string keyName, Byte[] pBuffer ) 
		{
			return this.GetFunction<NativeGetBinaryESBU>( this.Functions.GetBinary6 )( this.ObjectAddress, eConfigStore, keyName, pBuffer, (UInt32) pBuffer.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetBinaryWatermarkedESBU( IntPtr thisptr, EConfigStore eConfigStore, string keyName, Byte[] pBuffer, UInt32 uSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetBinaryWatermarked( EConfigStore eConfigStore, string keyName, Byte[] pBuffer ) 
		{
			return this.GetFunction<NativeGetBinaryWatermarkedESBU>( this.Functions.GetBinaryWatermarked7 )( this.ObjectAddress, eConfigStore, keyName, pBuffer, (UInt32) pBuffer.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetBoolESB( IntPtr thisptr, EConfigStore eConfigStore, string keyName, [MarshalAs(UnmanagedType.I1)] bool value );
		public void SetBool( EConfigStore eConfigStore, string keyName, bool value ) 
		{
			this.GetFunction<NativeSetBoolESB>( this.Functions.SetBool8 )( this.ObjectAddress, eConfigStore, keyName, value ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetIntESI( IntPtr thisptr, EConfigStore eConfigStore, string keyName, Int32 value );
		public void SetInt( EConfigStore eConfigStore, string keyName, Int32 value ) 
		{
			this.GetFunction<NativeSetIntESI>( this.Functions.SetInt9 )( this.ObjectAddress, eConfigStore, keyName, value ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetUint64ESU( IntPtr thisptr, EConfigStore eConfigStore, string keyName, UInt64 value );
		public void SetUint64( EConfigStore eConfigStore, string keyName, UInt64 value ) 
		{
			this.GetFunction<NativeSetUint64ESU>( this.Functions.SetUint6410 )( this.ObjectAddress, eConfigStore, keyName, value ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetFloatESF( IntPtr thisptr, EConfigStore eConfigStore, string keyName, float value );
		public void SetFloat( EConfigStore eConfigStore, string keyName, float value ) 
		{
			this.GetFunction<NativeSetFloatESF>( this.Functions.SetFloat11 )( this.ObjectAddress, eConfigStore, keyName, value ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetStringESS( IntPtr thisptr, EConfigStore eConfigStore, string keyName, string value );
		public void SetString( EConfigStore eConfigStore, string keyName, string value ) 
		{
			this.GetFunction<NativeSetStringESS>( this.Functions.SetString12 )( this.ObjectAddress, eConfigStore, keyName, value ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetBinaryESBU( IntPtr thisptr, EConfigStore eConfigStore, string keyName, Byte[] pBuffer, UInt32 uSize );
		public void SetBinary( EConfigStore eConfigStore, string keyName, Byte[] pBuffer ) 
		{
			this.GetFunction<NativeSetBinaryESBU>( this.Functions.SetBinary13 )( this.ObjectAddress, eConfigStore, keyName, pBuffer, (UInt32) pBuffer.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetBinaryWatermarkedESBU( IntPtr thisptr, EConfigStore eConfigStore, string keyName, Byte[] pBuffer, UInt32 uSize );
		public void SetBinaryWatermarked( EConfigStore eConfigStore, string keyName, Byte[] pBuffer ) 
		{
			this.GetFunction<NativeSetBinaryWatermarkedESBU>( this.Functions.SetBinaryWatermarked14 )( this.ObjectAddress, eConfigStore, keyName, pBuffer, (UInt32) pBuffer.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRemoveKeyES( IntPtr thisptr, EConfigStore eConfigStore, string keyName );
		public void RemoveKey( EConfigStore eConfigStore, string keyName ) 
		{
			this.GetFunction<NativeRemoveKeyES>( this.Functions.RemoveKey15 )( this.ObjectAddress, eConfigStore, keyName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetKeySerializedESBI( IntPtr thisptr, EConfigStore eConfigStore, string keyName, Byte[] pBuffer, Int32 iSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetKeySerialized( EConfigStore eConfigStore, string keyName, Byte[] pBuffer ) 
		{
			return this.GetFunction<NativeGetKeySerializedESBI>( this.Functions.GetKeySerialized16 )( this.ObjectAddress, eConfigStore, keyName, pBuffer, (Int32) pBuffer.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFlushToDiskB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool arg0 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool FlushToDisk( bool arg0 ) 
		{
			return this.GetFunction<NativeFlushToDiskB>( this.Functions.FlushToDisk17 )( this.ObjectAddress, arg0 ); 
		}
		
	};
}