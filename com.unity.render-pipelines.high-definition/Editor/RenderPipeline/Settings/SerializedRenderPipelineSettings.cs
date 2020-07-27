using System;
using UnityEngine.Serialization;
using UnityEngine.Rendering.HighDefinition;

namespace UnityEditor.Rendering.HighDefinition
{
    class SerializedLightSettings
    {
        public SerializedScalableSetting useContactShadows;

        public SerializedLightSettings(SerializedProperty root)
        {
            useContactShadows = new SerializedScalableSetting(root.Find((RenderPipelineSettings.LightSettings s) => s.useContactShadow));
        }
    }

    class SerializedRenderPipelineSettings
    {
        public SerializedProperty root;

        public SerializedProperty supportShadowMask;
        public SerializedProperty supportSSR;
        public SerializedProperty supportSSRTransparent;
        public SerializedProperty supportSSAO;
        public SerializedProperty supportSSGI;
        public SerializedProperty supportSubsurfaceScattering;
        public SerializedScalableSetting sssSampleBudget;
        [FormerlySerializedAs("supportVolumetric")]
        public SerializedProperty supportVolumetrics;
        public SerializedProperty supportLightLayers;
        public SerializedProperty supportedLitShaderMode;
        public SerializedProperty colorBufferFormat;
        public SerializedProperty supportCustomPass;
        public SerializedProperty customBufferFormat;

        public SerializedProperty supportDecals;
        public SerializedProperty supportDecalLayers;

        public bool supportMSAA => MSAASampleCount.GetEnumValue<UnityEngine.Rendering.MSAASamples>() != UnityEngine.Rendering.MSAASamples.None;
        public SerializedProperty MSAASampleCount;
        public SerializedProperty supportMotionVectors;
        public SerializedProperty supportRuntimeDebugDisplay;
        public SerializedProperty supportDitheringCrossFade;
        public SerializedProperty supportTerrainHole;
        public SerializedProperty supportRayTracing;
        public SerializedProperty supportedRayTracingMode;
        public SerializedProperty supportDistortion;
        public SerializedProperty supportTransparentBackface;
        public SerializedProperty supportTransparentDepthPrepass;
        public SerializedProperty supportTransparentDepthPostpass;
        internal SerializedProperty supportProbeVolume;


        public SerializedGlobalLightLoopSettings lightLoopSettings;
        public SerializedHDShadowInitParameters hdShadowInitParams;
        public SerializedGlobalDecalSettings decalSettings;
        public SerializedGlobalPostProcessSettings postProcessSettings;
        public SerializedDynamicResolutionSettings dynamicResolutionSettings;
        public SerializedLowResTransparencySettings lowresTransparentSettings;
        public SerializedXRSettings xrSettings;
        public SerializedPostProcessingQualitySettings postProcessQualitySettings;
        public SerializedLightingQualitySettings lightingQualitySettings;
        internal SerializedGlobalProbeVolumeSettings probeVolumeSettings;

        public SerializedLightSettings lightSettings;
        public SerializedScalableSetting lodBias;
        public SerializedScalableSetting maximumLODLevel;

    #pragma warning disable 618 // Type or member is obsolete
        [FormerlySerializedAs("enableUltraQualitySSS"), FormerlySerializedAs("increaseSssSampleCount"), Obsolete("For data migration")]
        SerializedProperty m_ObsoleteincreaseSssSampleCount;

        [FormerlySerializedAs("lightLayerName0"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletelightLayerName0;
        [FormerlySerializedAs("lightLayerName1"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletelightLayerName1;
        [FormerlySerializedAs("lightLayerName2"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletelightLayerName2;
        [FormerlySerializedAs("lightLayerName3"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletelightLayerName3;
        [FormerlySerializedAs("lightLayerName4"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletelightLayerName4;
        [FormerlySerializedAs("lightLayerName5"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletelightLayerName5;
        [FormerlySerializedAs("lightLayerName6"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletelightLayerName6;
        [FormerlySerializedAs("lightLayerName7"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletelightLayerName7;

        [FormerlySerializedAs("decalLayerName0"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletedecalLayerName0;
        [FormerlySerializedAs("decalLayerName1"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletedecalLayerName1;
        [FormerlySerializedAs("decalLayerName2"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletedecalLayerName2;
        [FormerlySerializedAs("decalLayerName3"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletedecalLayerName3;
        [FormerlySerializedAs("decalLayerName4"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletedecalLayerName4;
        [FormerlySerializedAs("decalLayerName5"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletedecalLayerName5;
        [FormerlySerializedAs("decalLayerName6"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletedecalLayerName6;
        [FormerlySerializedAs("decalLayerName7"), Obsolete("For data migration")]
        SerializedProperty m_ObsoletedecalLayerName7;
#pragma warning restore 618

        public SerializedRenderPipelineSettings(SerializedProperty root)
        {
            this.root = root;

            supportShadowMask               = root.Find((RenderPipelineSettings s) => s.supportShadowMask);
            supportSSR                      = root.Find((RenderPipelineSettings s) => s.supportSSR);
            supportSSRTransparent           = root.Find((RenderPipelineSettings s) => s.supportSSRTransparent);
            supportSSAO                     = root.Find((RenderPipelineSettings s) => s.supportSSAO);
            supportSSGI                     = root.Find((RenderPipelineSettings s) => s.supportSSGI);
            supportSubsurfaceScattering     = root.Find((RenderPipelineSettings s) => s.supportSubsurfaceScattering);
            sssSampleBudget                 = new SerializedScalableSetting(root.Find((RenderPipelineSettings s) => s.sssSampleBudget));
            supportVolumetrics              = root.Find((RenderPipelineSettings s) => s.supportVolumetrics);
            supportLightLayers              = root.Find((RenderPipelineSettings s) => s.supportLightLayers);
            colorBufferFormat               = root.Find((RenderPipelineSettings s) => s.colorBufferFormat);
            customBufferFormat              = root.Find((RenderPipelineSettings s) => s.customBufferFormat);
            supportCustomPass               = root.Find((RenderPipelineSettings s) => s.supportCustomPass);
            supportedLitShaderMode          = root.Find((RenderPipelineSettings s) => s.supportedLitShaderMode);

            supportDecals                   = root.Find((RenderPipelineSettings s) => s.supportDecals);
            supportDecalLayers              = root.Find((RenderPipelineSettings s) => s.supportDecalLayers);
            MSAASampleCount                 = root.Find((RenderPipelineSettings s) => s.msaaSampleCount);
            supportMotionVectors            = root.Find((RenderPipelineSettings s) => s.supportMotionVectors);
            supportRuntimeDebugDisplay      = root.Find((RenderPipelineSettings s) => s.supportRuntimeDebugDisplay);
            supportDitheringCrossFade       = root.Find((RenderPipelineSettings s) => s.supportDitheringCrossFade);
            supportTerrainHole              = root.Find((RenderPipelineSettings s) => s.supportTerrainHole);
            supportDistortion               = root.Find((RenderPipelineSettings s) => s.supportDistortion);
            supportTransparentBackface      = root.Find((RenderPipelineSettings s) => s.supportTransparentBackface);
            supportTransparentDepthPrepass  = root.Find((RenderPipelineSettings s) => s.supportTransparentDepthPrepass);
            supportTransparentDepthPostpass = root.Find((RenderPipelineSettings s) => s.supportTransparentDepthPostpass);
            supportProbeVolume              = root.Find((RenderPipelineSettings s) => s.supportProbeVolume);

            supportRayTracing               = root.Find((RenderPipelineSettings s) => s.supportRayTracing);
            supportedRayTracingMode         = root.Find((RenderPipelineSettings s) => s.supportedRayTracingMode);

            lightLoopSettings = new SerializedGlobalLightLoopSettings(root.Find((RenderPipelineSettings s) => s.lightLoopSettings));
            hdShadowInitParams = new SerializedHDShadowInitParameters(root.Find((RenderPipelineSettings s) => s.hdShadowInitParams));
            decalSettings     = new SerializedGlobalDecalSettings(root.Find((RenderPipelineSettings s) => s.decalSettings));
            postProcessSettings = new SerializedGlobalPostProcessSettings(root.Find((RenderPipelineSettings s) => s.postProcessSettings));
            dynamicResolutionSettings = new SerializedDynamicResolutionSettings(root.Find((RenderPipelineSettings s) => s.dynamicResolutionSettings));
            lowresTransparentSettings = new SerializedLowResTransparencySettings(root.Find((RenderPipelineSettings s) => s.lowresTransparentSettings));
            xrSettings = new SerializedXRSettings(root.Find((RenderPipelineSettings s) => s.xrSettings));
            postProcessQualitySettings = new SerializedPostProcessingQualitySettings(root.Find((RenderPipelineSettings s) => s.postProcessQualitySettings));
            probeVolumeSettings = new SerializedGlobalProbeVolumeSettings(root.Find((RenderPipelineSettings s) => s.probeVolumeSettings));

            lightSettings = new SerializedLightSettings(root.Find((RenderPipelineSettings s) => s.lightSettings));
            lodBias = new SerializedScalableSetting(root.Find((RenderPipelineSettings s) => s.lodBias));
            maximumLODLevel = new SerializedScalableSetting(root.Find((RenderPipelineSettings s) => s.maximumLODLevel));
            lightingQualitySettings = new SerializedLightingQualitySettings(root.Find((RenderPipelineSettings s) => s.lightingQualitySettings));

        #pragma warning disable 618 // Type or member is obsolete
            m_ObsoleteincreaseSssSampleCount = root.Find((RenderPipelineSettings s) => s.m_ObsoleteincreaseSssSampleCount);

            m_ObsoletelightLayerName0 = root.Find((RenderPipelineSettings s) => s.m_ObsoletelightLayerName0);
            m_ObsoletelightLayerName1 = root.Find((RenderPipelineSettings s) => s.m_ObsoletelightLayerName1);
            m_ObsoletelightLayerName2 = root.Find((RenderPipelineSettings s) => s.m_ObsoletelightLayerName2);
            m_ObsoletelightLayerName3 = root.Find((RenderPipelineSettings s) => s.m_ObsoletelightLayerName3);
            m_ObsoletelightLayerName4 = root.Find((RenderPipelineSettings s) => s.m_ObsoletelightLayerName4);
            m_ObsoletelightLayerName5 = root.Find((RenderPipelineSettings s) => s.m_ObsoletelightLayerName5);
            m_ObsoletelightLayerName6 = root.Find((RenderPipelineSettings s) => s.m_ObsoletelightLayerName6);
            m_ObsoletelightLayerName7 = root.Find((RenderPipelineSettings s) => s.m_ObsoletelightLayerName7);

            m_ObsoletedecalLayerName0 = root.Find((RenderPipelineSettings s) => s.m_ObsoletedecalLayerName0);
            m_ObsoletedecalLayerName1 = root.Find((RenderPipelineSettings s) => s.m_ObsoletedecalLayerName1);
            m_ObsoletedecalLayerName2 = root.Find((RenderPipelineSettings s) => s.m_ObsoletedecalLayerName2);
            m_ObsoletedecalLayerName3 = root.Find((RenderPipelineSettings s) => s.m_ObsoletedecalLayerName3);
            m_ObsoletedecalLayerName4 = root.Find((RenderPipelineSettings s) => s.m_ObsoletedecalLayerName4);
            m_ObsoletedecalLayerName5 = root.Find((RenderPipelineSettings s) => s.m_ObsoletedecalLayerName5);
            m_ObsoletedecalLayerName6 = root.Find((RenderPipelineSettings s) => s.m_ObsoletedecalLayerName6);
            m_ObsoletedecalLayerName7 = root.Find((RenderPipelineSettings s) => s.m_ObsoletedecalLayerName7);
#pragma warning restore 618
        }
    }
}
