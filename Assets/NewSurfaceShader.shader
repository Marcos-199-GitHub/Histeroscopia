Shader "Custom/ProceduralVeins"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _Scale ("Scale", Float) = 1.0
        _Tiling ("Tiling", Float) = 1.0
    }
    SubShader
    {
        Tags { "RenderType" = "Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 pos : POSITION;
                float2 uv : TEXCOORD0;
            };

            float _Scale;
            float _Tiling;
            fixed4 _Color;

            v2f vert (appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = o.pos.xy * _Tiling * _Scale;
                return o;
            }

            half4 frag (v2f i) : SV_Target
            {
                float noise = sin(i.uv.x * 10.0) * cos(i.uv.y * 10.0);
                float veinPattern = smoothstep(0.4, 0.6, noise);
                return _Color * veinPattern;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
