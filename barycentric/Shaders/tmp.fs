uniform sampler2D qt_Texture0;
varying highp vec4 qt_TexCoord0;

void main(void)
{

/* float ar = iResolution.x / iResolution.y;
     vec2 mc=vec2(0.0);
     vec2 uv = (gl_FragCoord.xy / iResolution.xy * 2. - 1.) * vec2(ar, 1.);
         if(iMouse.z==1.0)
          mc = (iMouse.xy    / iResolution.xy * 2. - 1.) * vec2(ar, 1.);


 vec2 a = vec2( .73,  .75);
 vec2 b = vec2(-.85,  .15);
 vec2 c = vec2( .25, -.75);
 vec3 barycoords;

 bool t0 = test(a, b, c, mc,barycoords);
  float l = 0.1;//df_bounds(uv, mc, a, b, c,barycoords);

 bool t1 = test(a, b, c, uv,barycoords);
 vec3 r = globalColor(uv,a,b,c);
 bool testcc = t1;
 vec3 color=vec3(0.0);
 // Visual debug lines and points.
    if (line(uv, a, b))
        color = vec3(1.0, 1.0, 0.0);
    if (line(uv, b, c))
        color = vec3(1.0, 0.0, 1.0);
    if (line(uv, c, a))
        color = vec3(0.0, 1.0, 1.0);
    if (df_circ(uv, a,EPS)<0.5*EPS)
       color = vec3(0.0, 1.0, 0.0);
   if (df_circ(uv, b,EPS)<0.5*EPS)
       color = vec3(1.0, 0.0, 0.0);
   if (df_circ(uv, c,EPS)<0.5*EPS)
       color = vec3(0.0, 0.0, 1.0);

 vec3 col = l > 0. ? (testcc ? color : vec3(1)-color) : (t1 ? r : (t0 ? COL3+color : COL2-color));*/
    gl_FragColor = texture2D(qt_Texture0, qt_TexCoord0.st);
}
