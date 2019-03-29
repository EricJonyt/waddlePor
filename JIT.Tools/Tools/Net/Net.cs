using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

/****************************************************************************************
*Copyringhrt (C) 2019 All Rights Reserved
*CLR版本: 4.0.30319.42000
*机器名称：DESKTOP-VTUBFCJ
*公司名称：
*命名空间：Net
*文件名：Net
*版本号：V1.0.0.0
*唯一标识：7044934e-874d-495d-ad04-b688c30cc704
*当前的用户域：DESKTOP-VTUBFCJ
*创建人：Lance
*电子邮箱：lance.liu@jitscm.com
*创建时间：2019/3/25 16:39:01

*描述：Start
*
*========================================================================================
*修改标记：
*修该时间：2019/3/25 16:39:01
*修改人：Lance
*版本号：V1.0.0.0
*========================================================================================
*
*描述：End


****************************************************************************************/
namespace Net
{
  /// <summary>
  /// 网络操作
  /// </summary>
  public class Net
  {

    #region Ip(获取Ip)

    /// <summary>
    /// 获取Ip
    /// </summary>
    public static string Ip
    {
      get
      {
        var result = string.Empty;
        if (HttpContext.Current != null)
          result = GetWebClientIp();
        if (string.IsNullOrWhiteSpace(result))
          result = GetLanIp();
        return result;
      }
    }

    /// <summary>
    /// 获取Web客户端的Ip
    /// </summary>
    private static string GetWebClientIp()
    {
      var ip = GetWebRemoteIp();
      foreach (var hostAddress in Dns.GetHostAddresses(ip))
      {
        if (hostAddress.AddressFamily == AddressFamily.InterNetwork)
          return hostAddress.ToString();
      }
      return string.Empty;
    }

    /// <summary>
    /// 获取Web远程Ip
    /// </summary>
    private static string GetWebRemoteIp()
    {
      try
      {
        return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] ?? HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
      }
      catch
      {
        return "";
      }
    }

    /// <summary>
    /// 获取局域网IP
    /// </summary>
    private static string GetLanIp()
    {
      foreach (var hostAddress in Dns.GetHostAddresses(Dns.GetHostName()))
      {
        if (hostAddress.AddressFamily == AddressFamily.InterNetwork)
          return hostAddress.ToString();
      }
      return string.Empty;
    }

    #endregion

    #region Host(获取主机名)

    /// <summary>
    /// 获取主机名
    /// </summary>
    public static string Host
    {
      get
      {
        return HttpContext.Current == null ? Dns.GetHostName() : GetWebClientHostName();
      }
    }

    /// <summary>
    /// 获取Web客户端主机名
    /// </summary>
    private static string GetWebClientHostName()
    {
      try
      {
        if (!HttpContext.Current.Request.IsLocal)
          return string.Empty;
        var ip = GetWebRemoteIp();
        var result = Dns.GetHostEntry(IPAddress.Parse(ip)).HostName;
        if (result == "localhost.localdomain")
          result = Dns.GetHostName();
        return result;
      }
      catch (Exception ex)
      {
        return string.Empty;
      }
    }

    #endregion


    #region 获取操作系统
    /// <summary>
    /// 获取操作系统+版本
    /// </summary>
    public static string GetWindows
    {
      get
      {
        var result = string.Empty;
        if (HttpContext.Current != null)
          result = GetWindowsV();
        if (string.IsNullOrEmpty(result))
          result = GetWindowsV();
        return result;
      }
    }

    /// <summary>
    /// 获取操作系统
    /// </summary>
    /// <returns></returns>
    private static string GetWindowsV()
    {
      return string.Format("{0}({1})", GetOsVersion(Environment.OSVersion.Version), Environment.OSVersion.VersionString);
    }

    /// <summary>
    /// 检测操作系统
    /// </summary>
    /// <param name="ver"></param>
    /// <returns></returns>
    private static string GetOsVersion(Version ver)
    {
      string strClient = "";
      if (ver.Major == 5 && ver.Minor == 1)
      {
        strClient = "Windows XP";
      }
      else if (ver.Major == 6 && ver.Minor == 0)
      {
        strClient = "Windows Vista";
      }
      else if (ver.Major == 6 && ver.Minor == 1)
      {
        strClient = "Windows 7";
      }
      else if (ver.Major == 5 && ver.Minor == 0)
      {
        strClient = "Windows 2000";
      }
      else if (ver.Major == 10 && ver.Minor == 0)
      {
        strClient = "Windows 10";
      }
      else
      {
        strClient = "未知";
      }
      return strClient;
    }



    /// <summary>
    /// 获取操作系统2
    /// </summary>

    public static string GetOSystemName
    {
      get
      {
        return GetOSystem(Environment.OSVersion.Version);
      }
    }

    /// <summary>
    /// 根据版本号转换为对应操作系统
    /// </summary>
    private static string GetOSystem(Version version)
    {
      const string Windows2000 = "5.0";
      const string WindowsXP = "5.1";
      const string Windows2003 = "5.2";
      const string Windows2008 = "6.0";
      const string Windows7 = "6.1";
      const string Windows8OrWindows81 = "6.2";
      const string Windows10 = "10.0";

      string OSystemName = string.Empty;

      switch (version.Major + "." + version.Minor)
      {
        case Windows2000:
          OSystemName = ("Windows 2000 (" + version.ToString() + ")");
          break;
        case WindowsXP:
          OSystemName = ("Windows XP (" + version.ToString() + ")");
          break;
        case Windows2003:
          OSystemName = ("Windows 2003 (" + version.ToString() + ")");
          break;
        case Windows2008:
          OSystemName = ("Windows 2008 (" + version.ToString() + ")");
          break;
        case Windows7:
          OSystemName = ("Windows 7 (" + version.ToString() + ")");
          break;
        case Windows8OrWindows81:
          OSystemName = ("Windows 8.O OR Windows 8.1 (" + version.ToString() + ")");
          break;
        case Windows10:
          OSystemName = ("Windows 10 (" + version.ToString() + ")");
          break;
        default:
          OSystemName = ("未知 (" + version.ToString() + ")");
          break;
      }
      return OSystemName;
    }

    #endregion


    #region 获取机器名

    /// <summary>
    /// 获取机器名
    /// </summary>
    /// <returns></returns>
    public static string GetWindowsN
    {
      get { return GetWindowsName(); }
    }

    /// <summary>
    /// 获取机器名
    /// </summary>
    /// <returns></returns>
    private static string GetWindowsName()
    {
      return Environment.MachineName.ToString();
    }
    #endregion

    #region 获取用户名

    /// <summary>
    /// 获取用户名
    /// </summary>
    /// <returns></returns>
    public static string GetWindowsUser
    {
      get
      {
        return GetWindowsUserName();
      }
    }

    /// <summary>
    /// 获取用户名
    /// </summary>
    /// <returns></returns>
    private static string GetWindowsUserName()
    {
      return Environment.UserName;
    }
    #endregion


    #region 获取用户的 Windows 登录名
    /// <summary>
    ///  获取用户的 Windows 登录名
    /// </summary>
    public static string HostName
    {
      get
      {
        return GeHostName();
      }
    }

    /// <summary>
    ///  获取用户的 Windows 登录名
    /// </summary>
    /// <returns></returns>
    private static string GeHostName()
    {
      try
      {
        WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();

        if (!HttpContext.Current.Request.IsLocal)
          return string.Empty;
        if (windowsIdentity != null)
          return windowsIdentity.Name;
      }
      catch (Exception ex)
      {
        return string.Empty;
      }
      return string.Empty;
    }
    #endregion

    #region Browser(获取浏览器信息)

    /// <summary>
    /// 获取浏览器信息
    /// </summary>
    public static string Browser
    {
      get
      {
        try
        {
          if (HttpContext.Current == null)
            return string.Empty;
          var browser = HttpContext.Current.Request.Browser;
          return string.Format("{0} {1}", browser.Browser, browser.Version);
        }
        catch { return string.Empty; }
      }
    }
    #endregion
  }
}
