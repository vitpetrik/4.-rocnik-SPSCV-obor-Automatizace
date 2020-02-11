<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE eagle SYSTEM "eagle.dtd">
<eagle version="9.5.0">
<drawing>
<settings>
<setting alwaysvectorfont="no"/>
<setting verticaltext="up"/>
</settings>
<grid distance="0.1" unitdist="inch" unit="inch" style="lines" multiple="1" display="yes" altdistance="0.01" altunitdist="inch" altunit="inch"/>
<layers>
<layer number="1" name="Top" color="4" fill="1" visible="no" active="no"/>
<layer number="2" name="Route2" color="1" fill="3" visible="no" active="no"/>
<layer number="3" name="Route3" color="4" fill="3" visible="no" active="no"/>
<layer number="4" name="Route4" color="1" fill="4" visible="no" active="no"/>
<layer number="5" name="Route5" color="4" fill="4" visible="no" active="no"/>
<layer number="6" name="Route6" color="1" fill="8" visible="no" active="no"/>
<layer number="7" name="Route7" color="4" fill="8" visible="no" active="no"/>
<layer number="8" name="Route8" color="1" fill="2" visible="no" active="no"/>
<layer number="9" name="Route9" color="4" fill="2" visible="no" active="no"/>
<layer number="10" name="Route10" color="1" fill="7" visible="no" active="no"/>
<layer number="11" name="Route11" color="4" fill="7" visible="no" active="no"/>
<layer number="12" name="Route12" color="1" fill="5" visible="no" active="no"/>
<layer number="13" name="Route13" color="4" fill="5" visible="no" active="no"/>
<layer number="14" name="Route14" color="1" fill="6" visible="no" active="no"/>
<layer number="15" name="Route15" color="4" fill="6" visible="no" active="no"/>
<layer number="16" name="Bottom" color="1" fill="1" visible="no" active="no"/>
<layer number="17" name="Pads" color="2" fill="1" visible="no" active="no"/>
<layer number="18" name="Vias" color="2" fill="1" visible="no" active="no"/>
<layer number="19" name="Unrouted" color="6" fill="1" visible="no" active="no"/>
<layer number="20" name="Dimension" color="15" fill="1" visible="no" active="no"/>
<layer number="21" name="tPlace" color="7" fill="1" visible="no" active="no"/>
<layer number="22" name="bPlace" color="7" fill="1" visible="no" active="no"/>
<layer number="23" name="tOrigins" color="15" fill="1" visible="no" active="no"/>
<layer number="24" name="bOrigins" color="15" fill="1" visible="no" active="no"/>
<layer number="25" name="tNames" color="7" fill="1" visible="no" active="no"/>
<layer number="26" name="bNames" color="7" fill="1" visible="no" active="no"/>
<layer number="27" name="tValues" color="7" fill="1" visible="no" active="no"/>
<layer number="28" name="bValues" color="7" fill="1" visible="no" active="no"/>
<layer number="29" name="tStop" color="7" fill="3" visible="no" active="no"/>
<layer number="30" name="bStop" color="7" fill="6" visible="no" active="no"/>
<layer number="31" name="tCream" color="7" fill="4" visible="no" active="no"/>
<layer number="32" name="bCream" color="7" fill="5" visible="no" active="no"/>
<layer number="33" name="tFinish" color="6" fill="3" visible="no" active="no"/>
<layer number="34" name="bFinish" color="6" fill="6" visible="no" active="no"/>
<layer number="35" name="tGlue" color="7" fill="4" visible="no" active="no"/>
<layer number="36" name="bGlue" color="7" fill="5" visible="no" active="no"/>
<layer number="37" name="tTest" color="7" fill="1" visible="no" active="no"/>
<layer number="38" name="bTest" color="7" fill="1" visible="no" active="no"/>
<layer number="39" name="tKeepout" color="4" fill="11" visible="no" active="no"/>
<layer number="40" name="bKeepout" color="1" fill="11" visible="no" active="no"/>
<layer number="41" name="tRestrict" color="4" fill="10" visible="no" active="no"/>
<layer number="42" name="bRestrict" color="1" fill="10" visible="no" active="no"/>
<layer number="43" name="vRestrict" color="2" fill="10" visible="no" active="no"/>
<layer number="44" name="Drills" color="7" fill="1" visible="no" active="no"/>
<layer number="45" name="Holes" color="7" fill="1" visible="no" active="no"/>
<layer number="46" name="Milling" color="3" fill="1" visible="no" active="no"/>
<layer number="47" name="Measures" color="7" fill="1" visible="no" active="no"/>
<layer number="48" name="Document" color="7" fill="1" visible="no" active="no"/>
<layer number="49" name="Reference" color="7" fill="1" visible="no" active="no"/>
<layer number="51" name="tDocu" color="7" fill="1" visible="no" active="no"/>
<layer number="52" name="bDocu" color="7" fill="1" visible="no" active="no"/>
<layer number="88" name="SimResults" color="9" fill="1" visible="yes" active="yes"/>
<layer number="89" name="SimProbes" color="9" fill="1" visible="yes" active="yes"/>
<layer number="90" name="Modules" color="5" fill="1" visible="yes" active="yes"/>
<layer number="91" name="Nets" color="2" fill="1" visible="yes" active="yes"/>
<layer number="92" name="Busses" color="1" fill="1" visible="yes" active="yes"/>
<layer number="93" name="Pins" color="2" fill="1" visible="no" active="yes"/>
<layer number="94" name="Symbols" color="4" fill="1" visible="yes" active="yes"/>
<layer number="95" name="Names" color="7" fill="1" visible="yes" active="yes"/>
<layer number="96" name="Values" color="7" fill="1" visible="yes" active="yes"/>
<layer number="97" name="Info" color="7" fill="1" visible="yes" active="yes"/>
<layer number="98" name="Guide" color="6" fill="1" visible="yes" active="yes"/>
</layers>
<schematic xreflabel="%F%N/%S.%C%R" xrefpart="/%S.%C%R">
<libraries>
<library name="74ttl-din" urn="urn:adsk.eagle:library:84">
<description>&lt;b&gt;TTL Devices with DIN Symbols&lt;/b&gt;&lt;p&gt;
CadSoft and the author do not warrant that this library is free from error
or will meet your specific requirements.&lt;p&gt;
&lt;author&gt;Created by Holger Bettenbühl, hol.bet.@rhein-main.net&lt;/author&gt;</description>
<packages>
<package name="DIL14" urn="urn:adsk.eagle:footprint:16136/1" library_version="5">
<description>&lt;b&gt;Dual In Line Package&lt;/b&gt;</description>
<wire x1="8.89" y1="2.921" x2="-8.89" y2="2.921" width="0.1524" layer="21"/>
<wire x1="-8.89" y1="-2.921" x2="8.89" y2="-2.921" width="0.1524" layer="21"/>
<wire x1="8.89" y1="2.921" x2="8.89" y2="-2.921" width="0.1524" layer="21"/>
<wire x1="-8.89" y1="2.921" x2="-8.89" y2="1.016" width="0.1524" layer="21"/>
<wire x1="-8.89" y1="-2.921" x2="-8.89" y2="-1.016" width="0.1524" layer="21"/>
<wire x1="-8.89" y1="1.016" x2="-8.89" y2="-1.016" width="0.1524" layer="21" curve="-180"/>
<pad name="1" x="-7.62" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="2" x="-5.08" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="7" x="7.62" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="8" x="7.62" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="3" x="-2.54" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="4" x="0" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="6" x="5.08" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="5" x="2.54" y="-3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="9" x="5.08" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="10" x="2.54" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="11" x="0" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="12" x="-2.54" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="13" x="-5.08" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<pad name="14" x="-7.62" y="3.81" drill="0.8128" shape="long" rot="R90"/>
<text x="-9.271" y="-3.048" size="1.27" layer="25" ratio="10" rot="R90">&gt;NAME</text>
<text x="-6.731" y="-0.635" size="1.27" layer="27" ratio="10">&gt;VALUE</text>
</package>
</packages>
<packages3d>
<package3d name="DIL14" urn="urn:adsk.eagle:package:16407/2" type="model" library_version="5">
<description>Dual In Line Package</description>
<packageinstances>
<packageinstance name="DIL14"/>
</packageinstances>
</package3d>
</packages3d>
<symbols>
<symbol name="+UB" urn="urn:adsk.eagle:symbol:1255/1" library_version="5">
<circle x="0" y="-0.635" radius="0.635" width="0.1524" layer="94"/>
<text x="1.27" y="-1.27" size="1.524" layer="95">&gt;NAME</text>
<pin name="+UB" x="0" y="2.54" visible="pad" length="short" direction="pwr" rot="R270"/>
</symbol>
<symbol name="-UB" urn="urn:adsk.eagle:symbol:1256/1" library_version="5">
<wire x1="0" y1="-0.635" x2="0" y2="0.635" width="0" layer="94"/>
<wire x1="0.635" y1="0" x2="-0.635" y2="0" width="0" layer="94"/>
<circle x="0" y="0.635" radius="0.635" width="0.1524" layer="94"/>
<text x="1.27" y="0" size="1.524" layer="95">&gt;NAME</text>
<pin name="-UB" x="0" y="-2.54" visible="pad" length="short" direction="pwr" rot="R90"/>
</symbol>
<symbol name="74" urn="urn:adsk.eagle:symbol:1280/1" library_version="5">
<wire x1="-5.08" y1="-10.16" x2="5.08" y2="-10.16" width="0.254" layer="94"/>
<wire x1="-5.08" y1="-10.16" x2="-5.08" y2="-7.62" width="0.254" layer="94"/>
<wire x1="-5.08" y1="10.16" x2="5.08" y2="10.16" width="0.254" layer="94"/>
<wire x1="5.08" y1="10.16" x2="5.08" y2="5.08" width="0.254" layer="94"/>
<wire x1="-5.08" y1="7.62" x2="-7.62" y2="8.89" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="7.62" x2="-5.08" y2="10.16" width="0.254" layer="94"/>
<wire x1="-7.62" y1="8.89" x2="-7.62" y2="7.62" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="-7.62" x2="-7.62" y2="-6.35" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="-7.62" x2="-5.08" y2="-2.54" width="0.254" layer="94"/>
<wire x1="-7.62" y1="-6.35" x2="-7.62" y2="-7.62" width="0.1524" layer="94"/>
<wire x1="7.62" y1="-5.08" x2="5.08" y2="-3.81" width="0.1524" layer="94"/>
<wire x1="5.08" y1="-3.81" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="-5.08" y1="3.5306" x2="-3.0988" y2="2.54" width="0.1524" layer="94"/>
<wire x1="-3.0988" y1="2.54" x2="-5.08" y2="1.5494" width="0.1524" layer="94"/>
<wire x1="5.08" y1="5.08" x2="7.62" y2="5.08" width="0.1524" layer="94"/>
<wire x1="5.08" y1="5.08" x2="5.08" y2="-3.81" width="0.254" layer="94"/>
<wire x1="5.08" y1="-5.08" x2="7.62" y2="-5.08" width="0.1524" layer="94"/>
<wire x1="5.08" y1="-5.08" x2="5.08" y2="-10.16" width="0.254" layer="94"/>
<wire x1="-7.62" y1="7.62" x2="-5.08" y2="7.62" width="0.1524" layer="94"/>
<wire x1="-7.62" y1="2.54" x2="-5.08" y2="2.54" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="2.54" x2="-5.08" y2="7.62" width="0.254" layer="94"/>
<wire x1="-7.62" y1="-2.54" x2="-5.08" y2="-2.54" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="-2.54" x2="-5.08" y2="2.54" width="0.254" layer="94"/>
<wire x1="-7.62" y1="-7.62" x2="-5.08" y2="-7.62" width="0.1524" layer="94"/>
<text x="-5.08" y="-13.335" size="2.032" layer="96">&gt;VALUE</text>
<text x="-5.08" y="10.795" size="2.032" layer="95">&gt;NAME</text>
<text x="-3.81" y="6.35" size="2.032" layer="94">S</text>
<text x="-1.905" y="1.27" size="2.032" layer="94">C</text>
<text x="-3.81" y="-3.81" size="2.032" layer="94">D</text>
<text x="-3.81" y="-8.89" size="2.032" layer="94">R</text>
<pin name="CLK" x="-10.16" y="2.54" visible="pad" length="short" direction="in"/>
<pin name="!PRE" x="-10.16" y="7.62" visible="pad" length="short" direction="in"/>
<pin name="Q" x="10.16" y="5.08" visible="pad" length="short" direction="out" rot="R180"/>
<pin name="!CLR" x="-10.16" y="-7.62" visible="pad" length="short" direction="in"/>
<pin name="D" x="-10.16" y="-2.54" visible="pad" length="short" direction="in"/>
<pin name="!Q" x="10.16" y="-5.08" visible="pad" length="short" direction="out" rot="R180"/>
</symbol>
<symbol name="10" urn="urn:adsk.eagle:symbol:1261/1" library_version="5">
<wire x1="-5.08" y1="-7.62" x2="-5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="7.62" x2="-5.08" y2="7.62" width="0.254" layer="94"/>
<wire x1="5.08" y1="7.62" x2="5.08" y2="1.27" width="0.254" layer="94"/>
<wire x1="-5.08" y1="-7.62" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<wire x1="7.62" y1="0" x2="5.08" y2="1.27" width="0.1524" layer="94"/>
<wire x1="5.08" y1="1.27" x2="5.08" y2="0" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="7.62" y2="0" width="0.1524" layer="94"/>
<wire x1="-7.62" y1="5.08" x2="-5.08" y2="5.08" width="0.1524" layer="94"/>
<wire x1="-7.62" y1="0" x2="-5.08" y2="0" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="0" x2="-5.08" y2="7.62" width="0.254" layer="94"/>
<wire x1="-7.62" y1="-5.08" x2="-5.08" y2="-5.08" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="-5.08" x2="-5.08" y2="0" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="5.08" y2="-7.62" width="0.254" layer="94"/>
<text x="-5.08" y="8.255" size="2.032" layer="95">&gt;NAME</text>
<text x="-5.08" y="-10.795" size="2.032" layer="96">&gt;VALUE</text>
<text x="-0.635" y="4.445" size="2.032" layer="94">&amp;</text>
<pin name="A" x="-10.16" y="5.08" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="B" x="-10.16" y="0" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="Y" x="10.16" y="0" visible="pad" length="short" direction="out" rot="R180"/>
<pin name="C" x="-10.16" y="-5.08" visible="pad" length="short" direction="in" swaplevel="1"/>
</symbol>
<symbol name="00" urn="urn:adsk.eagle:symbol:1257/1" library_version="5">
<wire x1="-0.635" y1="0" x2="0.635" y2="0" width="0" layer="94"/>
<wire x1="0" y1="0.635" x2="0" y2="-0.635" width="0" layer="94"/>
<wire x1="-5.08" y1="-5.08" x2="-5.08" y2="-2.54" width="0.254" layer="94"/>
<wire x1="5.08" y1="5.08" x2="-5.08" y2="5.08" width="0.254" layer="94"/>
<wire x1="5.08" y1="5.08" x2="5.08" y2="1.27" width="0.254" layer="94"/>
<wire x1="-5.08" y1="-5.08" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="7.62" y1="0" x2="5.08" y2="1.27" width="0.1524" layer="94"/>
<wire x1="5.08" y1="1.27" x2="5.08" y2="0" width="0.254" layer="94"/>
<wire x1="5.08" y1="0" x2="7.62" y2="0" width="0.1524" layer="94"/>
<wire x1="5.08" y1="0" x2="5.08" y2="-5.08" width="0.254" layer="94"/>
<wire x1="-7.62" y1="2.54" x2="-5.08" y2="2.54" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="2.54" x2="-5.08" y2="5.08" width="0.254" layer="94"/>
<wire x1="-7.62" y1="-2.54" x2="-5.08" y2="-2.54" width="0.1524" layer="94"/>
<wire x1="-5.08" y1="-2.54" x2="-5.08" y2="2.54" width="0.254" layer="94"/>
<text x="-5.08" y="5.715" size="2.032" layer="95">&gt;NAME</text>
<text x="-5.08" y="-8.255" size="2.032" layer="96">&gt;VALUE</text>
<text x="-0.635" y="1.905" size="2.032" layer="94">&amp;</text>
<pin name="A" x="-10.16" y="2.54" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="B" x="-10.16" y="-2.54" visible="pad" length="short" direction="in" swaplevel="1"/>
<pin name="Y" x="10.16" y="0" visible="pad" length="short" direction="out" rot="R180"/>
</symbol>
</symbols>
<devicesets>
<deviceset name="74*74" urn="urn:adsk.eagle:component:1485/5" prefix="V" library_version="5">
<description>Dual D type positive edge triggered &lt;b&gt;FLIP FLOP&lt;/b&gt;, preset and clear</description>
<gates>
<gate name="/+UB" symbol="+UB" x="15.24" y="5.08" addlevel="request"/>
<gate name="/-UB" symbol="-UB" x="15.24" y="-5.08" addlevel="request"/>
<gate name="/1" symbol="74" x="0" y="0" swaplevel="1"/>
<gate name="/2" symbol="74" x="-25.4" y="0" swaplevel="1"/>
</gates>
<devices>
<device name="N" package="DIL14">
<connects>
<connect gate="/+UB" pin="+UB" pad="14"/>
<connect gate="/-UB" pin="-UB" pad="7"/>
<connect gate="/1" pin="!CLR" pad="1"/>
<connect gate="/1" pin="!PRE" pad="4"/>
<connect gate="/1" pin="!Q" pad="6"/>
<connect gate="/1" pin="CLK" pad="3"/>
<connect gate="/1" pin="D" pad="2"/>
<connect gate="/1" pin="Q" pad="5"/>
<connect gate="/2" pin="!CLR" pad="13"/>
<connect gate="/2" pin="!PRE" pad="10"/>
<connect gate="/2" pin="!Q" pad="8"/>
<connect gate="/2" pin="CLK" pad="11"/>
<connect gate="/2" pin="D" pad="12"/>
<connect gate="/2" pin="Q" pad="9"/>
</connects>
<package3dinstances>
<package3dinstance package3d_urn="urn:adsk.eagle:package:16407/2"/>
</package3dinstances>
<technologies>
<technology name="">
<attribute name="POPULARITY" value="0" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="74*10" urn="urn:adsk.eagle:component:1470/5" prefix="V" library_version="5">
<description>Triple 3-input &lt;b&gt;NAND&lt;/b&gt; gate</description>
<gates>
<gate name="/+UB" symbol="+UB" x="12.7" y="17.78" addlevel="request"/>
<gate name="/-UB" symbol="-UB" x="12.7" y="5.08" addlevel="request"/>
<gate name="/1" symbol="10" x="0" y="0" swaplevel="1"/>
<gate name="/2" symbol="10" x="0" y="22.86" swaplevel="1"/>
<gate name="/3" symbol="10" x="-22.86" y="10.16" swaplevel="1"/>
</gates>
<devices>
<device name="N" package="DIL14">
<connects>
<connect gate="/+UB" pin="+UB" pad="14"/>
<connect gate="/-UB" pin="-UB" pad="7"/>
<connect gate="/1" pin="A" pad="1"/>
<connect gate="/1" pin="B" pad="2"/>
<connect gate="/1" pin="C" pad="13"/>
<connect gate="/1" pin="Y" pad="12"/>
<connect gate="/2" pin="A" pad="3"/>
<connect gate="/2" pin="B" pad="4"/>
<connect gate="/2" pin="C" pad="5"/>
<connect gate="/2" pin="Y" pad="6"/>
<connect gate="/3" pin="A" pad="9"/>
<connect gate="/3" pin="B" pad="10"/>
<connect gate="/3" pin="C" pad="11"/>
<connect gate="/3" pin="Y" pad="8"/>
</connects>
<package3dinstances>
<package3dinstance package3d_urn="urn:adsk.eagle:package:16407/2"/>
</package3dinstances>
<technologies>
<technology name="">
<attribute name="POPULARITY" value="0" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
<deviceset name="74*00" urn="urn:adsk.eagle:component:1466/5" prefix="V" library_version="5">
<description>Quad 2-input &lt;b&gt;NAND&lt;/b&gt; gate</description>
<gates>
<gate name="/+UB" symbol="+UB" x="15.24" y="12.7" addlevel="request"/>
<gate name="/-UB" symbol="-UB" x="15.24" y="5.08" addlevel="request"/>
<gate name="/1" symbol="00" x="0" y="0" swaplevel="1"/>
<gate name="/2" symbol="00" x="0" y="17.78" swaplevel="1"/>
<gate name="/3" symbol="00" x="-22.86" y="0" swaplevel="1"/>
<gate name="/4" symbol="00" x="-22.86" y="17.78" swaplevel="1"/>
</gates>
<devices>
<device name="N" package="DIL14">
<connects>
<connect gate="/+UB" pin="+UB" pad="14"/>
<connect gate="/-UB" pin="-UB" pad="7"/>
<connect gate="/1" pin="A" pad="1"/>
<connect gate="/1" pin="B" pad="2"/>
<connect gate="/1" pin="Y" pad="3"/>
<connect gate="/2" pin="A" pad="4"/>
<connect gate="/2" pin="B" pad="5"/>
<connect gate="/2" pin="Y" pad="6"/>
<connect gate="/3" pin="A" pad="9"/>
<connect gate="/3" pin="B" pad="10"/>
<connect gate="/3" pin="Y" pad="8"/>
<connect gate="/4" pin="A" pad="12"/>
<connect gate="/4" pin="B" pad="13"/>
<connect gate="/4" pin="Y" pad="11"/>
</connects>
<package3dinstances>
<package3dinstance package3d_urn="urn:adsk.eagle:package:16407/2"/>
</package3dinstances>
<technologies>
<technology name="">
<attribute name="POPULARITY" value="0" constant="no"/>
</technology>
<technology name="HC">
<attribute name="POPULARITY" value="0" constant="no"/>
</technology>
<technology name="HCT">
<attribute name="POPULARITY" value="0" constant="no"/>
</technology>
<technology name="LS">
<attribute name="POPULARITY" value="0" constant="no"/>
</technology>
</technologies>
</device>
</devices>
</deviceset>
</devicesets>
</library>
<library name="supply2" urn="urn:adsk.eagle:library:372">
<description>&lt;b&gt;Supply Symbols&lt;/b&gt;&lt;p&gt;
GND, VCC, 0V, +5V, -5V, etc.&lt;p&gt;
Please keep in mind, that these devices are necessary for the
automatic wiring of the supply signals.&lt;p&gt;
The pin name defined in the symbol is identical to the net which is to be wired automatically.&lt;p&gt;
In this library the device names are the same as the pin names of the symbols, therefore the correct signal names appear next to the supply symbols in the schematic.&lt;p&gt;
&lt;author&gt;Created by librarian@cadsoft.de&lt;/author&gt;</description>
<packages>
</packages>
<symbols>
<symbol name="V--&gt;" urn="urn:adsk.eagle:symbol:27002/1" library_version="2">
<wire x1="15.24" y1="0" x2="13.97" y2="1.27" width="0.1524" layer="94"/>
<wire x1="13.97" y1="1.27" x2="0" y2="1.27" width="0.1524" layer="94"/>
<wire x1="0" y1="1.27" x2="0" y2="-1.27" width="0.1524" layer="94"/>
<wire x1="0" y1="-1.27" x2="13.97" y2="-1.27" width="0.1524" layer="94"/>
<wire x1="15.24" y1="0" x2="13.97" y2="-1.27" width="0.1524" layer="94"/>
<text x="1.27" y="-0.762" size="1.778" layer="96">&gt;VALUE</text>
</symbol>
</symbols>
<devicesets>
<deviceset name="V--&gt;" urn="urn:adsk.eagle:component:27049/1" prefix="SUPPLY" library_version="2">
<description>&lt;b&gt;SUPPLY SYMBOL&lt;/b&gt;</description>
<gates>
<gate name="G$1" symbol="V--&gt;" x="0" y="0"/>
</gates>
<devices>
<device name="">
<technologies>
<technology name=""/>
</technologies>
</device>
</devices>
</deviceset>
</devicesets>
</library>
<library name="supply1" urn="urn:adsk.eagle:library:371">
<description>&lt;b&gt;Supply Symbols&lt;/b&gt;&lt;p&gt;
 GND, VCC, 0V, +5V, -5V, etc.&lt;p&gt;
 Please keep in mind, that these devices are necessary for the
 automatic wiring of the supply signals.&lt;p&gt;
 The pin name defined in the symbol is identical to the net which is to be wired automatically.&lt;p&gt;
 In this library the device names are the same as the pin names of the symbols, therefore the correct signal names appear next to the supply symbols in the schematic.&lt;p&gt;
 &lt;author&gt;Created by librarian@cadsoft.de&lt;/author&gt;</description>
<packages>
</packages>
<symbols>
<symbol name="VDD" urn="urn:adsk.eagle:symbol:26943/1" library_version="1">
<wire x1="1.27" y1="-1.905" x2="0" y2="0" width="0.254" layer="94"/>
<wire x1="0" y1="0" x2="-1.27" y2="-1.905" width="0.254" layer="94"/>
<wire x1="0" y1="1.27" x2="-1.27" y2="-1.905" width="0.254" layer="94"/>
<wire x1="1.27" y1="-1.905" x2="0" y2="1.27" width="0.254" layer="94"/>
<text x="-2.54" y="-2.54" size="1.778" layer="96" rot="R90">&gt;VALUE</text>
<pin name="VDD" x="0" y="-2.54" visible="off" length="short" direction="sup" rot="R90"/>
</symbol>
</symbols>
<devicesets>
<deviceset name="VDD" urn="urn:adsk.eagle:component:26970/1" prefix="VDD" library_version="1">
<description>&lt;b&gt;SUPPLY SYMBOL&lt;/b&gt;</description>
<gates>
<gate name="G$1" symbol="VDD" x="0" y="0"/>
</gates>
<devices>
<device name="">
<technologies>
<technology name=""/>
</technologies>
</device>
</devices>
</deviceset>
</devicesets>
</library>
</libraries>
<attributes>
</attributes>
<variantdefs>
</variantdefs>
<classes>
<class number="0" name="default" width="0" drill="0">
</class>
</classes>
<parts>
<part name="IO1" library="74ttl-din" library_urn="urn:adsk.eagle:library:84" deviceset="74*74" device="N" package3d_urn="urn:adsk.eagle:package:16407/2"/>
<part name="IO2" library="74ttl-din" library_urn="urn:adsk.eagle:library:84" deviceset="74*74" device="N" package3d_urn="urn:adsk.eagle:package:16407/2"/>
<part name="IO4" library="74ttl-din" library_urn="urn:adsk.eagle:library:84" deviceset="74*10" device="N" package3d_urn="urn:adsk.eagle:package:16407/2"/>
<part name="CLK" library="supply2" library_urn="urn:adsk.eagle:library:372" deviceset="V--&gt;" device="" value="CLK"/>
<part name="IO3" library="74ttl-din" library_urn="urn:adsk.eagle:library:84" deviceset="74*00" device="N" package3d_urn="urn:adsk.eagle:package:16407/2"/>
<part name="VDD1" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="VDD" device="" value="A"/>
<part name="VDD2" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="VDD" device="" value="B"/>
<part name="VDD3" library="supply1" library_urn="urn:adsk.eagle:library:371" deviceset="VDD" device="" value="C"/>
</parts>
<sheets>
<sheet>
<plain>
</plain>
<instances>
<instance part="IO1" gate="/1" x="35.56" y="25.4" smashed="yes">
<attribute name="VALUE" x="30.48" y="12.065" size="2.032" layer="96"/>
<attribute name="NAME" x="30.48" y="36.195" size="2.032" layer="95"/>
</instance>
<instance part="IO1" gate="/2" x="91.44" y="25.4" smashed="yes">
<attribute name="VALUE" x="86.36" y="12.065" size="2.032" layer="96"/>
<attribute name="NAME" x="86.36" y="36.195" size="2.032" layer="95"/>
</instance>
<instance part="IO2" gate="/1" x="142.24" y="25.4" smashed="yes">
<attribute name="VALUE" x="137.16" y="12.065" size="2.032" layer="96"/>
<attribute name="NAME" x="137.16" y="36.195" size="2.032" layer="95"/>
</instance>
<instance part="IO4" gate="/1" x="99.06" y="81.28" smashed="yes">
<attribute name="NAME" x="93.98" y="89.535" size="2.032" layer="95"/>
<attribute name="VALUE" x="93.98" y="70.485" size="2.032" layer="96"/>
</instance>
<instance part="IO4" gate="/2" x="154.94" y="81.28" smashed="yes">
<attribute name="NAME" x="149.86" y="89.535" size="2.032" layer="95"/>
<attribute name="VALUE" x="149.86" y="70.485" size="2.032" layer="96"/>
</instance>
<instance part="IO4" gate="/3" x="180.34" y="81.28" smashed="yes">
<attribute name="NAME" x="175.26" y="89.535" size="2.032" layer="95"/>
<attribute name="VALUE" x="175.26" y="70.485" size="2.032" layer="96"/>
</instance>
<instance part="CLK" gate="G$1" x="0" y="0" smashed="yes">
<attribute name="VALUE" x="6.35" y="0.762" size="1.778" layer="96" rot="R180"/>
</instance>
<instance part="IO3" gate="/1" x="25.4" y="60.96" smashed="yes">
<attribute name="NAME" x="20.32" y="66.675" size="2.032" layer="95"/>
<attribute name="VALUE" x="20.32" y="52.705" size="2.032" layer="96"/>
</instance>
<instance part="IO3" gate="/2" x="68.58" y="45.72" smashed="yes">
<attribute name="NAME" x="63.5" y="51.435" size="2.032" layer="95"/>
<attribute name="VALUE" x="63.5" y="37.465" size="2.032" layer="96"/>
</instance>
<instance part="IO3" gate="/3" x="129.54" y="58.42" smashed="yes">
<attribute name="NAME" x="124.46" y="64.135" size="2.032" layer="95"/>
<attribute name="VALUE" x="124.46" y="50.165" size="2.032" layer="96"/>
</instance>
<instance part="VDD1" gate="G$1" x="53.34" y="96.52" smashed="yes">
<attribute name="VALUE" x="50.8" y="99.06" size="1.778" layer="96" rot="R180"/>
</instance>
<instance part="VDD2" gate="G$1" x="116.84" y="96.52" smashed="yes">
<attribute name="VALUE" x="114.3" y="99.06" size="1.778" layer="96" rot="R180"/>
</instance>
<instance part="VDD3" gate="G$1" x="177.8" y="30.48" smashed="yes" rot="R270">
<attribute name="VALUE" x="180.34" y="33.02" size="1.778" layer="96"/>
</instance>
</instances>
<busses>
</busses>
<nets>
<net name="B$1" class="0">
<segment>
<pinref part="IO1" gate="/1" pin="CLK"/>
<wire x1="25.4" y1="27.94" x2="22.86" y2="27.94" width="0.1524" layer="91"/>
<wire x1="22.86" y1="27.94" x2="20.32" y2="25.4" width="0.1524" layer="91" curve="90"/>
<wire x1="20.32" y1="25.4" x2="20.32" y2="0" width="0.1524" layer="91"/>
<wire x1="15.24" y1="0" x2="20.32" y2="0" width="0.1524" layer="91"/>
<pinref part="IO1" gate="/2" pin="CLK"/>
<wire x1="81.28" y1="27.94" x2="68.58" y2="27.94" width="0.1524" layer="91"/>
<wire x1="68.58" y1="27.94" x2="66.04" y2="25.4" width="0.1524" layer="91" curve="90"/>
<wire x1="66.04" y1="25.4" x2="66.04" y2="0" width="0.1524" layer="91"/>
<wire x1="20.32" y1="0" x2="66.04" y2="0" width="0.1524" layer="91"/>
<junction x="20.32" y="0"/>
<wire x1="66.04" y1="0" x2="119.38" y2="0" width="0.1524" layer="91"/>
<wire x1="119.38" y1="0" x2="121.92" y2="2.54" width="0.1524" layer="91" curve="90"/>
<wire x1="121.92" y1="2.54" x2="121.92" y2="25.4" width="0.1524" layer="91"/>
<junction x="66.04" y="0"/>
<pinref part="IO2" gate="/1" pin="CLK"/>
<wire x1="132.08" y1="27.94" x2="124.46" y2="27.94" width="0.1524" layer="91"/>
<wire x1="124.46" y1="27.94" x2="121.92" y2="25.4" width="0.1524" layer="91" curve="90"/>
</segment>
</net>
<net name="N$6" class="0">
<segment>
<pinref part="IO1" gate="/2" pin="!Q"/>
<wire x1="101.6" y1="20.32" x2="114.3" y2="20.32" width="0.1524" layer="91"/>
<wire x1="114.3" y1="20.32" x2="116.84" y2="22.86" width="0.1524" layer="91" curve="90"/>
<wire x1="116.84" y1="22.86" x2="116.84" y2="53.34" width="0.1524" layer="91"/>
<pinref part="IO3" gate="/3" pin="B"/>
<wire x1="116.84" y1="53.34" x2="119.38" y2="55.88" width="0.1524" layer="91" curve="-90"/>
</segment>
</net>
<net name="N$7" class="0">
<segment>
<pinref part="IO2" gate="/1" pin="!Q"/>
<wire x1="152.4" y1="20.32" x2="160.02" y2="20.32" width="0.1524" layer="91"/>
<wire x1="160.02" y1="20.32" x2="162.56" y2="22.86" width="0.1524" layer="91" curve="90"/>
<wire x1="162.56" y1="22.86" x2="162.56" y2="38.1" width="0.1524" layer="91"/>
<wire x1="162.56" y1="38.1" x2="160.02" y2="40.64" width="0.1524" layer="91" curve="90"/>
<wire x1="160.02" y1="40.64" x2="114.3" y2="40.64" width="0.1524" layer="91"/>
<wire x1="114.3" y1="40.64" x2="111.76" y2="43.18" width="0.1524" layer="91" curve="-90"/>
<pinref part="IO3" gate="/3" pin="A"/>
<wire x1="111.76" y1="43.18" x2="111.76" y2="58.42" width="0.1524" layer="91"/>
<wire x1="111.76" y1="58.42" x2="114.3" y2="60.96" width="0.1524" layer="91" curve="-90"/>
<wire x1="114.3" y1="60.96" x2="119.38" y2="60.96" width="0.1524" layer="91"/>
</segment>
</net>
<net name="N$8" class="0">
<segment>
<pinref part="IO4" gate="/1" pin="Y"/>
<pinref part="IO4" gate="/2" pin="B"/>
<wire x1="109.22" y1="81.28" x2="137.16" y2="81.28" width="0.1524" layer="91"/>
<pinref part="IO4" gate="/2" pin="A"/>
<wire x1="137.16" y1="81.28" x2="144.78" y2="81.28" width="0.1524" layer="91"/>
<wire x1="144.78" y1="86.36" x2="139.7" y2="86.36" width="0.1524" layer="91"/>
<wire x1="139.7" y1="86.36" x2="137.16" y2="83.82" width="0.1524" layer="91" curve="90"/>
<wire x1="137.16" y1="83.82" x2="137.16" y2="81.28" width="0.1524" layer="91"/>
<junction x="137.16" y="81.28"/>
</segment>
</net>
<net name="N$9" class="0">
<segment>
<wire x1="142.24" y1="60.96" x2="142.24" y2="73.66" width="0.1524" layer="91"/>
<pinref part="IO4" gate="/2" pin="C"/>
<wire x1="142.24" y1="73.66" x2="144.78" y2="76.2" width="0.1524" layer="91" curve="-90"/>
<pinref part="IO3" gate="/3" pin="Y"/>
<wire x1="142.24" y1="60.96" x2="139.7" y2="58.42" width="0.1524" layer="91" curve="-90"/>
</segment>
</net>
<net name="N$10" class="0">
<segment>
<pinref part="IO4" gate="/2" pin="Y"/>
<pinref part="IO4" gate="/3" pin="B"/>
<wire x1="165.1" y1="81.28" x2="167.64" y2="81.28" width="0.1524" layer="91"/>
<pinref part="IO4" gate="/3" pin="A"/>
<wire x1="167.64" y1="81.28" x2="170.18" y2="81.28" width="0.1524" layer="91"/>
<wire x1="170.18" y1="86.36" x2="167.64" y2="83.82" width="0.1524" layer="91" curve="90"/>
<wire x1="167.64" y1="83.82" x2="167.64" y2="81.28" width="0.1524" layer="91"/>
<junction x="167.64" y="81.28"/>
<pinref part="IO4" gate="/3" pin="C"/>
<wire x1="167.64" y1="81.28" x2="167.64" y2="78.74" width="0.1524" layer="91"/>
<wire x1="167.64" y1="78.74" x2="170.18" y2="76.2" width="0.1524" layer="91" curve="90"/>
</segment>
</net>
<net name="N$11" class="0">
<segment>
<pinref part="IO4" gate="/3" pin="Y"/>
<wire x1="190.5" y1="81.28" x2="193.04" y2="78.74" width="0.1524" layer="91" curve="-90"/>
<wire x1="193.04" y1="78.74" x2="193.04" y2="48.26" width="0.1524" layer="91"/>
<wire x1="193.04" y1="48.26" x2="190.5" y2="45.72" width="0.1524" layer="91" curve="-90"/>
<wire x1="190.5" y1="45.72" x2="129.54" y2="45.72" width="0.1524" layer="91"/>
<wire x1="129.54" y1="45.72" x2="127" y2="43.18" width="0.1524" layer="91" curve="90"/>
<wire x1="127" y1="43.18" x2="127" y2="25.4" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/1" pin="D"/>
<wire x1="127" y1="25.4" x2="129.54" y2="22.86" width="0.1524" layer="91" curve="90"/>
<wire x1="129.54" y1="22.86" x2="132.08" y2="22.86" width="0.1524" layer="91"/>
</segment>
</net>
<net name="A" class="0">
<segment>
<pinref part="IO1" gate="/1" pin="Q"/>
<wire x1="45.72" y1="30.48" x2="50.8" y2="30.48" width="0.1524" layer="91"/>
<wire x1="50.8" y1="30.48" x2="53.34" y2="33.02" width="0.1524" layer="91" curve="90"/>
<wire x1="53.34" y1="33.02" x2="53.34" y2="48.26" width="0.1524" layer="91"/>
<pinref part="VDD1" gate="G$1" pin="VDD"/>
<wire x1="53.34" y1="48.26" x2="53.34" y2="86.36" width="0.1524" layer="91"/>
<pinref part="IO3" gate="/1" pin="B"/>
<wire x1="53.34" y1="86.36" x2="53.34" y2="93.98" width="0.1524" layer="91"/>
<wire x1="15.24" y1="58.42" x2="12.7" y2="55.88" width="0.1524" layer="91" curve="90"/>
<wire x1="12.7" y1="55.88" x2="12.7" y2="50.8" width="0.1524" layer="91"/>
<wire x1="12.7" y1="50.8" x2="15.24" y2="48.26" width="0.1524" layer="91" curve="90"/>
<wire x1="15.24" y1="48.26" x2="53.34" y2="48.26" width="0.1524" layer="91"/>
<junction x="53.34" y="48.26"/>
<pinref part="IO4" gate="/1" pin="A"/>
<wire x1="88.9" y1="86.36" x2="53.34" y2="86.36" width="0.1524" layer="91"/>
<junction x="53.34" y="86.36"/>
<pinref part="IO3" gate="/2" pin="A"/>
<wire x1="53.34" y1="48.26" x2="58.42" y2="48.26" width="0.1524" layer="91"/>
</segment>
</net>
<net name="N$1" class="0">
<segment>
<pinref part="IO3" gate="/1" pin="Y"/>
<wire x1="35.56" y1="60.96" x2="38.1" y2="60.96" width="0.1524" layer="91"/>
<wire x1="38.1" y1="60.96" x2="40.64" y2="63.5" width="0.1524" layer="91" curve="90"/>
<wire x1="40.64" y1="63.5" x2="40.64" y2="73.66" width="0.1524" layer="91"/>
<wire x1="40.64" y1="73.66" x2="38.1" y2="76.2" width="0.1524" layer="91" curve="90"/>
<wire x1="38.1" y1="76.2" x2="5.08" y2="76.2" width="0.1524" layer="91"/>
<wire x1="5.08" y1="76.2" x2="2.54" y2="73.66" width="0.1524" layer="91" curve="90"/>
<wire x1="2.54" y1="73.66" x2="2.54" y2="25.4" width="0.1524" layer="91"/>
<pinref part="IO1" gate="/1" pin="D"/>
<wire x1="2.54" y1="25.4" x2="5.08" y2="22.86" width="0.1524" layer="91" curve="90"/>
<wire x1="5.08" y1="22.86" x2="25.4" y2="22.86" width="0.1524" layer="91"/>
</segment>
</net>
<net name="N$2" class="0">
<segment>
<pinref part="IO3" gate="/1" pin="A"/>
<wire x1="15.24" y1="63.5" x2="12.7" y2="63.5" width="0.1524" layer="91"/>
<wire x1="12.7" y1="63.5" x2="10.16" y2="66.04" width="0.1524" layer="91" curve="-90"/>
<wire x1="10.16" y1="66.04" x2="10.16" y2="68.58" width="0.1524" layer="91"/>
<wire x1="10.16" y1="68.58" x2="12.7" y2="71.12" width="0.1524" layer="91" curve="-90"/>
<wire x1="12.7" y1="71.12" x2="45.72" y2="71.12" width="0.1524" layer="91"/>
<wire x1="45.72" y1="71.12" x2="48.26" y2="68.58" width="0.1524" layer="91" curve="-90"/>
<wire x1="48.26" y1="68.58" x2="48.26" y2="60.96" width="0.1524" layer="91"/>
<pinref part="IO2" gate="/1" pin="Q"/>
<wire x1="152.4" y1="30.48" x2="154.94" y2="30.48" width="0.1524" layer="91"/>
<wire x1="154.94" y1="30.48" x2="157.48" y2="27.94" width="0.1524" layer="91" curve="-90"/>
<wire x1="157.48" y1="27.94" x2="157.48" y2="7.62" width="0.1524" layer="91"/>
<wire x1="157.48" y1="7.62" x2="154.94" y2="5.08" width="0.1524" layer="91" curve="-90"/>
<wire x1="154.94" y1="5.08" x2="111.76" y2="5.08" width="0.1524" layer="91"/>
<wire x1="111.76" y1="5.08" x2="109.22" y2="7.62" width="0.1524" layer="91" curve="-90"/>
<wire x1="109.22" y1="7.62" x2="109.22" y2="53.34" width="0.1524" layer="91"/>
<wire x1="104.14" y1="58.42" x2="109.22" y2="53.34" width="0.1524" layer="91" curve="-90"/>
<wire x1="104.14" y1="58.42" x2="83.82" y2="58.42" width="0.1524" layer="91"/>
<pinref part="IO4" gate="/1" pin="C"/>
<wire x1="88.9" y1="76.2" x2="86.36" y2="76.2" width="0.1524" layer="91"/>
<wire x1="86.36" y1="76.2" x2="83.82" y2="73.66" width="0.1524" layer="91" curve="90"/>
<wire x1="83.82" y1="73.66" x2="83.82" y2="58.42" width="0.1524" layer="91"/>
<pinref part="VDD3" gate="G$1" pin="VDD"/>
<wire x1="175.26" y1="30.48" x2="154.94" y2="30.48" width="0.1524" layer="91"/>
<junction x="154.94" y="30.48"/>
<wire x1="83.82" y1="58.42" x2="50.8" y2="58.42" width="0.1524" layer="91"/>
<wire x1="50.8" y1="58.42" x2="48.26" y2="60.96" width="0.1524" layer="91" curve="-90"/>
<junction x="83.82" y="58.42"/>
</segment>
</net>
<net name="N$3" class="0">
<segment>
<pinref part="IO3" gate="/2" pin="Y"/>
<wire x1="78.74" y1="45.72" x2="81.28" y2="45.72" width="0.1524" layer="91"/>
<wire x1="81.28" y1="45.72" x2="83.82" y2="43.18" width="0.1524" layer="91" curve="-90"/>
<wire x1="83.82" y1="43.18" x2="83.82" y2="40.64" width="0.1524" layer="91"/>
<wire x1="83.82" y1="40.64" x2="81.28" y2="38.1" width="0.1524" layer="91" curve="-90"/>
<wire x1="81.28" y1="38.1" x2="76.2" y2="38.1" width="0.1524" layer="91"/>
<wire x1="76.2" y1="38.1" x2="73.66" y2="35.56" width="0.1524" layer="91" curve="90"/>
<wire x1="73.66" y1="35.56" x2="73.66" y2="25.4" width="0.1524" layer="91"/>
<pinref part="IO1" gate="/2" pin="D"/>
<wire x1="73.66" y1="25.4" x2="76.2" y2="22.86" width="0.1524" layer="91" curve="90"/>
<wire x1="76.2" y1="22.86" x2="81.28" y2="22.86" width="0.1524" layer="91"/>
</segment>
</net>
<net name="VDD" class="0">
<segment>
<pinref part="VDD2" gate="G$1" pin="VDD"/>
<wire x1="116.84" y1="93.98" x2="116.84" y2="68.58" width="0.1524" layer="91"/>
<wire x1="78.74" y1="55.88" x2="104.14" y2="55.88" width="0.1524" layer="91"/>
<wire x1="104.14" y1="55.88" x2="106.68" y2="53.34" width="0.1524" layer="91" curve="-90"/>
<wire x1="106.68" y1="53.34" x2="106.68" y2="33.02" width="0.1524" layer="91"/>
<pinref part="IO1" gate="/2" pin="Q"/>
<wire x1="106.68" y1="33.02" x2="104.14" y2="30.48" width="0.1524" layer="91" curve="-90"/>
<wire x1="104.14" y1="30.48" x2="101.6" y2="30.48" width="0.1524" layer="91"/>
<pinref part="IO4" gate="/1" pin="B"/>
<wire x1="88.9" y1="81.28" x2="81.28" y2="81.28" width="0.1524" layer="91"/>
<wire x1="81.28" y1="81.28" x2="78.74" y2="78.74" width="0.1524" layer="91" curve="90"/>
<wire x1="78.74" y1="78.74" x2="78.74" y2="55.88" width="0.1524" layer="91"/>
<wire x1="78.74" y1="55.88" x2="58.42" y2="55.88" width="0.1524" layer="91"/>
<wire x1="58.42" y1="55.88" x2="55.88" y2="53.34" width="0.1524" layer="91" curve="90"/>
<wire x1="55.88" y1="53.34" x2="55.88" y2="45.72" width="0.1524" layer="91"/>
<junction x="78.74" y="55.88"/>
<pinref part="IO3" gate="/2" pin="B"/>
<wire x1="58.42" y1="43.18" x2="55.88" y2="45.72" width="0.1524" layer="91" curve="-90"/>
<wire x1="106.68" y1="53.34" x2="106.68" y2="63.5" width="0.1524" layer="91"/>
<wire x1="106.68" y1="63.5" x2="109.22" y2="66.04" width="0.1524" layer="91" curve="-90"/>
<wire x1="109.22" y1="66.04" x2="114.3" y2="66.04" width="0.1524" layer="91"/>
<junction x="106.68" y="53.34"/>
<wire x1="114.3" y1="66.04" x2="116.84" y2="68.58" width="0.1524" layer="91" curve="90"/>
</segment>
</net>
</nets>
</sheet>
</sheets>
<errors>
<approved hash="205,1,35.56,30.3344,V1/+UB,+UB,,,,"/>
<approved hash="205,1,35.56,30.3344,V1/-UB,-UB,,,,"/>
<approved hash="202,1,25.4,22.86,V1/1,!CLR,,,,"/>
<approved hash="202,1,25.4,27.94,V1/1,D,,,,"/>
<approved hash="202,1,81.28,38.1,V1/2,!PRE,,,,"/>
<approved hash="202,1,81.28,22.86,V1/2,!CLR,,,,"/>
<approved hash="205,1,142.24,30.3344,V2/+UB,+UB,,,,"/>
<approved hash="205,1,142.24,30.3344,V2/-UB,-UB,,,,"/>
<approved hash="202,1,132.08,38.1,V2/1,!PRE,,,,"/>
<approved hash="202,1,132.08,22.86,V2/1,!CLR,,,,"/>
<approved hash="114,1,142.24,30.3344,V2,/2,CLK,,,"/>
<approved hash="114,1,142.24,30.3344,V2,/2,!PRE,,,"/>
<approved hash="114,1,142.24,30.3344,V2,/2,!CLR,,,"/>
<approved hash="114,1,142.24,30.3344,V2,/2,D,,,"/>
<approved hash="205,1,99.06,86.2144,V4/+UB,+UB,,,,"/>
<approved hash="205,1,99.06,86.2144,V4/-UB,-UB,,,,"/>
<approved hash="205,1,38.1,65.8944,V3/+UB,+UB,,,,"/>
<approved hash="205,1,38.1,65.8944,V3/-UB,-UB,,,,"/>
<approved hash="114,1,38.1,65.8944,V3,/4,A,,,"/>
<approved hash="114,1,38.1,65.8944,V3,/4,B,,,"/>
<approved hash="209,1,25.4,33.02,B$1,,,,,"/>
<approved hash="209,1,81.28,33.02,B$1,,,,,"/>
<approved hash="209,1,132.08,33.02,B$1,,,,,"/>
<approved hash="110,1,73.66,27.94,B$1,N$3,,,,"/>
<approved hash="110,1,73.66,27.94,B$1,N$3,,,,"/>
<approved hash="110,1,114.3,45.72,N$6,N$7,,,,"/>
<approved hash="110,1,114.3,45.72,N$6,N$7,,,,"/>
<approved hash="110,1,127,33.02,N$11,B$1,,,,"/>
<approved hash="110,1,127,33.02,N$11,B$1,,,,"/>
</errors>
</schematic>
</drawing>
<compatibility>
<note version="8.2" severity="warning">
Since Version 8.2, EAGLE supports online libraries. The ids
of those online libraries will not be understood (or retained)
with this version.
</note>
<note version="8.3" severity="warning">
Since Version 8.3, EAGLE supports URNs for individual library
assets (packages, symbols, and devices). The URNs of those assets
will not be understood (or retained) with this version.
</note>
<note version="8.3" severity="warning">
Since Version 8.3, EAGLE supports the association of 3D packages
with devices in libraries, schematics, and board files. Those 3D
packages will not be understood (or retained) with this version.
</note>
</compatibility>
</eagle>
