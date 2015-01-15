﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextureFormat : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.TextureFormat o = (UnityEngine.TextureFormat)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextureFormat");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Alpha8");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "ARGB4444");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "RGB24");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "RGBA32");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "ARGB32");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "RGB565");
		LuaDLL.lua_pushinteger(l, 10);
		LuaDLL.lua_setfield(l, -2, "DXT1");
		LuaDLL.lua_pushinteger(l, 12);
		LuaDLL.lua_setfield(l, -2, "DXT5");
		LuaDLL.lua_pushinteger(l, 13);
		LuaDLL.lua_setfield(l, -2, "RGBA4444");
		LuaDLL.lua_pushinteger(l, 14);
		LuaDLL.lua_setfield(l, -2, "BGRA32");
		LuaDLL.lua_pushinteger(l, 30);
		LuaDLL.lua_setfield(l, -2, "PVRTC_RGB2");
		LuaDLL.lua_pushinteger(l, 31);
		LuaDLL.lua_setfield(l, -2, "PVRTC_RGBA2");
		LuaDLL.lua_pushinteger(l, 32);
		LuaDLL.lua_setfield(l, -2, "PVRTC_RGB4");
		LuaDLL.lua_pushinteger(l, 33);
		LuaDLL.lua_setfield(l, -2, "PVRTC_RGBA4");
		LuaDLL.lua_pushinteger(l, 34);
		LuaDLL.lua_setfield(l, -2, "ETC_RGB4");
		LuaDLL.lua_pushinteger(l, 35);
		LuaDLL.lua_setfield(l, -2, "ATC_RGB4");
		LuaDLL.lua_pushinteger(l, 36);
		LuaDLL.lua_setfield(l, -2, "ATC_RGBA8");
		LuaDLL.lua_pushinteger(l, 38);
		LuaDLL.lua_setfield(l, -2, "ATF_RGB_DXT1");
		LuaDLL.lua_pushinteger(l, 39);
		LuaDLL.lua_setfield(l, -2, "ATF_RGBA_JPG");
		LuaDLL.lua_pushinteger(l, 40);
		LuaDLL.lua_setfield(l, -2, "ATF_RGB_JPG");
		LuaDLL.lua_pushinteger(l, 41);
		LuaDLL.lua_setfield(l, -2, "EAC_R");
		LuaDLL.lua_pushinteger(l, 42);
		LuaDLL.lua_setfield(l, -2, "EAC_R_SIGNED");
		LuaDLL.lua_pushinteger(l, 43);
		LuaDLL.lua_setfield(l, -2, "EAC_RG");
		LuaDLL.lua_pushinteger(l, 44);
		LuaDLL.lua_setfield(l, -2, "EAC_RG_SIGNED");
		LuaDLL.lua_pushinteger(l, 45);
		LuaDLL.lua_setfield(l, -2, "ETC2_RGB");
		LuaDLL.lua_pushinteger(l, 46);
		LuaDLL.lua_setfield(l, -2, "ETC2_RGBA1");
		LuaDLL.lua_pushinteger(l, 47);
		LuaDLL.lua_setfield(l, -2, "ETC2_RGBA8");
		LuaDLL.lua_pushinteger(l, 48);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGB_4x4");
		LuaDLL.lua_pushinteger(l, 49);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGB_5x5");
		LuaDLL.lua_pushinteger(l, 50);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGB_6x6");
		LuaDLL.lua_pushinteger(l, 51);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGB_8x8");
		LuaDLL.lua_pushinteger(l, 52);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGB_10x10");
		LuaDLL.lua_pushinteger(l, 53);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGB_12x12");
		LuaDLL.lua_pushinteger(l, 54);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGBA_4x4");
		LuaDLL.lua_pushinteger(l, 55);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGBA_5x5");
		LuaDLL.lua_pushinteger(l, 56);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGBA_6x6");
		LuaDLL.lua_pushinteger(l, 57);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGBA_8x8");
		LuaDLL.lua_pushinteger(l, 58);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGBA_10x10");
		LuaDLL.lua_pushinteger(l, 59);
		LuaDLL.lua_setfield(l, -2, "ASTC_RGBA_12x12");
		LuaDLL.lua_pushinteger(l, 30);
		LuaDLL.lua_setfield(l, -2, "PVRTC_2BPP_RGB");
		LuaDLL.lua_pushinteger(l, 31);
		LuaDLL.lua_setfield(l, -2, "PVRTC_2BPP_RGBA");
		LuaDLL.lua_pushinteger(l, 32);
		LuaDLL.lua_setfield(l, -2, "PVRTC_4BPP_RGB");
		LuaDLL.lua_pushinteger(l, 33);
		LuaDLL.lua_setfield(l, -2, "PVRTC_4BPP_RGBA");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}