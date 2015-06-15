<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
   
   
  
    <xsl:output method="html"/>

    <xsl:template match="/">
      <html>
        <head>
          
          <title>
            Do Van Tuan 
          </title>
          <!--<link rel="stylesheet" type="text/css" href="Stylesheet.css"/> -->
        </head>
        <body>

          <div id="dms"><h1>DANH MỤC SÁCH</h1>
          </div>
          <xsl:for-each select="//CoSo" >
            <div id="khung">
            <h3> Co So: <xsl:value-of select="@TenCS"/> <br/>
            </h3>
            <xsl:for-each select="NhaXB">
              <h4>Nha Xuat Ban : <xsl:value-of select="TenNXB"/>
              </h4> <br/>

              <table border="2" align="center" width="80%" cellspacing="0" >
                <tr>
                  <th align="center">STT</th>
                  <th align="center">Tên Sách</th>
                  <th align="center">Số Trang</th>
                  <th align="center">Giá</th>
                </tr>
                <xsl:for-each select="Sach">
                  <tr>
                    <td align="center">
                      <xsl:value-of select="position()"/>
                    </td>
                    <td align="center">
                      <xsl:value-of select="TenSach"/>
                    </td >
                    <td align="center">
                      <xsl:value-of select="SoTrang"/>
                    </td>
                    <xsl:variable name="sotrang" select="SoTrang"/>
                    <td align="center">
                      <xsl:value-of select="$sotrang * 3000"/> .d
                    </td>
                  </tr>
                </xsl:for-each>
              </table>
              </xsl:for-each>
            </div>
          </xsl:for-each>
         
        </body>
      </html>
    </xsl:template>

</xsl:stylesheet>
