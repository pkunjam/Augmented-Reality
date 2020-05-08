// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Shader created with Shader Forge v1.18 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.18;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:3138,x:34025,y:32913,varname:node_3138,prsc:2|emission-7118-OUT,alpha-1857-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:3754,x:30838,y:33063,varname:node_3754,prsc:2;n:type:ShaderForge.SFN_Append,id:99,x:31565,y:33034,varname:node_99,prsc:2|A-1283-OUT,B-2853-OUT;n:type:ShaderForge.SFN_Time,id:5664,x:30838,y:33319,varname:node_5664,prsc:2;n:type:ShaderForge.SFN_Add,id:4165,x:31857,y:33372,varname:node_4165,prsc:2|A-9529-UVOUT,B-8858-OUT;n:type:ShaderForge.SFN_OneMinus,id:684,x:32120,y:33353,varname:node_684,prsc:2|IN-4165-OUT;n:type:ShaderForge.SFN_ComponentMask,id:2059,x:32394,y:33306,varname:node_2059,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-684-OUT;n:type:ShaderForge.SFN_Frac,id:6322,x:32622,y:33224,varname:node_6322,prsc:2|IN-2059-OUT;n:type:ShaderForge.SFN_Vector1,id:9732,x:32514,y:33421,varname:node_9732,prsc:2,v1:31;n:type:ShaderForge.SFN_Power,id:5755,x:32829,y:33224,varname:node_5755,prsc:2|VAL-6322-OUT,EXP-1719-OUT;n:type:ShaderForge.SFN_Slider,id:7704,x:32639,y:33603,ptovrint:False,ptlb:HoloLineAlpha,ptin:_HoloLineAlpha,varname:node_7704,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Multiply,id:4443,x:33042,y:33242,varname:node_4443,prsc:2|A-5755-OUT,B-7704-OUT;n:type:ShaderForge.SFN_Slider,id:2088,x:32868,y:33718,ptovrint:False,ptlb:HoloAlpha,ptin:_HoloAlpha,varname:node_2088,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.6,max:1;n:type:ShaderForge.SFN_Add,id:1857,x:33268,y:33381,varname:node_1857,prsc:2|A-4443-OUT,B-2088-OUT;n:type:ShaderForge.SFN_Time,id:6950,x:31282,y:32734,varname:node_6950,prsc:2;n:type:ShaderForge.SFN_ScreenPos,id:8644,x:31282,y:32575,varname:node_8644,prsc:2,sctp:0;n:type:ShaderForge.SFN_Multiply,id:6779,x:31485,y:32665,varname:node_6779,prsc:2|A-8644-UVOUT,B-6950-TSL;n:type:ShaderForge.SFN_Tex2d,id:9580,x:31691,y:32224,ptovrint:False,ptlb:Main Tex,ptin:_MainTex,varname:node_9580,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7a1a37fe0bef389489da6a362870be6b,ntxv:1,isnm:False;n:type:ShaderForge.SFN_Desaturate,id:6744,x:31913,y:32414,varname:node_6744,prsc:2|COL-9580-RGB,DES-368-OUT;n:type:ShaderForge.SFN_Color,id:1885,x:31945,y:32154,ptovrint:False,ptlb:HoloColor,ptin:_HoloColor,varname:node_1885,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.9586205,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:2989,x:32171,y:32291,varname:node_2989,prsc:2|A-1885-RGB,B-6744-OUT;n:type:ShaderForge.SFN_Noise,id:6609,x:31666,y:32547,varname:node_6609,prsc:2|XY-6779-OUT;n:type:ShaderForge.SFN_RemapRange,id:3226,x:31860,y:32608,varname:node_3226,prsc:2,frmn:0,frmx:1,tomn:0.5,tomx:1|IN-6609-OUT;n:type:ShaderForge.SFN_Vector1,id:4137,x:31860,y:32844,varname:node_4137,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:5809,x:32045,y:32713,varname:node_5809,prsc:2|A-3226-OUT,B-4137-OUT;n:type:ShaderForge.SFN_Vector1,id:9660,x:32067,y:32528,varname:node_9660,prsc:2,v1:1;n:type:ShaderForge.SFN_Lerp,id:9583,x:32280,y:32884,varname:node_9583,prsc:2|A-9660-OUT,B-5809-OUT,T-4137-OUT;n:type:ShaderForge.SFN_Multiply,id:9904,x:32830,y:32746,varname:node_9904,prsc:2|A-2989-OUT,B-5457-OUT;n:type:ShaderForge.SFN_Multiply,id:2855,x:33087,y:32813,varname:node_2855,prsc:2|A-2963-OUT,B-9904-OUT;n:type:ShaderForge.SFN_Vector1,id:2963,x:32886,y:32626,varname:node_2963,prsc:2,v1:1.5;n:type:ShaderForge.SFN_Add,id:9857,x:33283,y:32839,varname:node_9857,prsc:2|A-2855-OUT,B-4443-OUT;n:type:ShaderForge.SFN_Multiply,id:7118,x:33533,y:32898,varname:node_7118,prsc:2|A-9857-OUT,B-1857-OUT;n:type:ShaderForge.SFN_Slider,id:6728,x:30860,y:33506,ptovrint:False,ptlb:HoloSpeed,ptin:_HoloSpeed,varname:node_6728,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3,max:1;n:type:ShaderForge.SFN_Multiply,id:8858,x:31293,y:33408,varname:node_8858,prsc:2|A-5664-T,B-6728-OUT;n:type:ShaderForge.SFN_Slider,id:3184,x:32315,y:33549,ptovrint:False,ptlb:HoloLineThickness,ptin:_HoloLineThickness,varname:node_3184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:2,max:30;n:type:ShaderForge.SFN_Subtract,id:1719,x:32703,y:33421,varname:node_1719,prsc:2|A-9732-OUT,B-3184-OUT;n:type:ShaderForge.SFN_Slider,id:5001,x:32123,y:33061,ptovrint:False,ptlb:HoloNoise,ptin:_HoloNoise,varname:node_5001,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2,max:1;n:type:ShaderForge.SFN_OneMinus,id:5340,x:32471,y:32987,varname:node_5340,prsc:2|IN-5001-OUT;n:type:ShaderForge.SFN_Max,id:5457,x:32664,y:32870,varname:node_5457,prsc:2|A-9583-OUT,B-5340-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:3440,x:31282,y:32435,varname:node_3440,prsc:2;n:type:ShaderForge.SFN_Slider,id:175,x:30818,y:32926,ptovrint:False,ptlb:HoloLineSeparation,ptin:_HoloLineSeparation,varname:node_175,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:1,max:10;n:type:ShaderForge.SFN_Divide,id:1283,x:31222,y:32972,varname:node_1283,prsc:2|A-3754-X,B-175-OUT;n:type:ShaderForge.SFN_Divide,id:2853,x:31253,y:33094,varname:node_2853,prsc:2|A-3754-Y,B-175-OUT;n:type:ShaderForge.SFN_Vector1,id:368,x:31603,y:32419,varname:node_368,prsc:2,v1:0.8;n:type:ShaderForge.SFN_Rotator,id:9529,x:31766,y:33092,varname:node_9529,prsc:2|UVIN-99-OUT,ANG-9161-OUT;n:type:ShaderForge.SFN_Slider,id:6203,x:31027,y:33260,ptovrint:False,ptlb:HoloLineRotation,ptin:_HoloLineRotation,varname:node_6203,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:180;n:type:ShaderForge.SFN_RemapRange,id:9161,x:31424,y:33256,varname:node_9161,prsc:2,frmn:0,frmx:180,tomn:0,tomx:3.1416|IN-6203-OUT;proporder:9580-1885-2088-6728-5001-175-3184-7704-6203;pass:END;sub:END;*/

Shader "3y3net/HoloShader" {
    Properties {
        _MainTex ("Main Tex", 2D) = "gray" {}
        _HoloColor ("HoloColor", Color) = (0,0.9586205,1,1)
        _HoloAlpha ("HoloAlpha", Range(0, 1)) = 0.6
        _HoloSpeed ("HoloSpeed", Range(0, 1)) = 0.3
        _HoloNoise ("HoloNoise", Range(0, 1)) = 0.2
        _HoloLineSeparation ("HoloLineSeparation", Range(0.1, 10)) = 1
        _HoloLineThickness ("HoloLineThickness", Range(1, 30)) = 2
        _HoloLineAlpha ("HoloLineAlpha", Range(0, 1)) = 0.5
        _HoloLineRotation ("HoloLineRotation", Range(0, 180)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float _HoloLineAlpha;
            uniform float _HoloAlpha;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _HoloColor;
            uniform float _HoloSpeed;
            uniform float _HoloLineThickness;
            uniform float _HoloNoise;
            uniform float _HoloLineSeparation;
            uniform float _HoloLineRotation;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float4 screenPos : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos(v.vertex);
                o.screenPos = o.pos;
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
/////// Vectors:
////// Lighting:
////// Emissive:
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float4 node_6950 = _Time + _TimeEditor;
                float2 node_6779 = (i.screenPos.rg*node_6950.r);
                float2 node_6609_skew = node_6779 + 0.2127+node_6779.x*0.3713*node_6779.y;
                float2 node_6609_rnd = 4.789*sin(489.123*(node_6609_skew));
                float node_6609 = frac(node_6609_rnd.x*node_6609_rnd.y*(1+node_6609_skew.x));
                float node_4137 = 1.0;
                float node_9529_ang = (_HoloLineRotation*0.01745333+0.0);
                float node_9529_spd = 1.0;
                float node_9529_cos = cos(node_9529_spd*node_9529_ang);
                float node_9529_sin = sin(node_9529_spd*node_9529_ang);
                float2 node_9529_piv = float2(0.5,0.5);
                float2 node_9529 = (mul(float2((i.posWorld.r/_HoloLineSeparation),(i.posWorld.g/_HoloLineSeparation))-node_9529_piv,float2x2( node_9529_cos, -node_9529_sin, node_9529_sin, node_9529_cos))+node_9529_piv);
                float4 node_5664 = _Time + _TimeEditor;
                float node_4443 = (pow(frac((1.0 - (node_9529+(node_5664.g*_HoloSpeed))).g),(31.0-_HoloLineThickness))*_HoloLineAlpha);
                float node_1857 = (node_4443+_HoloAlpha);
                float3 emissive = (((1.5*((_HoloColor.rgb*lerp(_MainTex_var.rgb,dot(_MainTex_var.rgb,float3(0.3,0.59,0.11)),0.8))*max(lerp(1.0,((node_6609*0.5+0.5)*node_4137),node_4137),(1.0 - _HoloNoise))))+node_4443)*node_1857);
                float3 finalColor = emissive;
                return fixed4(finalColor,node_1857);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
