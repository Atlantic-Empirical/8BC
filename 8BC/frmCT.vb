Option Explicit On 

Friend Class frmCT
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "

    Public Sub New(ByVal FilePath As String)
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.SetUpCT(FilePath)

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents oCol As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents oColDex As System.Windows.Forms.GroupBox
    Public WithEvents _oCol_255 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_254 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_253 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_252 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_251 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_250 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_249 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_248 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_247 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_246 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_245 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_244 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_243 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_242 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_241 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_240 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_239 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_238 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_237 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_236 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_235 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_234 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_233 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_232 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_231 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_230 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_229 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_228 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_227 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_226 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_225 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_224 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_223 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_222 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_221 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_220 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_219 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_218 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_217 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_216 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_215 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_214 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_213 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_212 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_211 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_210 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_209 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_208 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_207 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_206 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_205 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_204 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_203 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_202 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_201 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_200 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_199 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_198 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_197 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_196 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_195 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_194 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_193 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_192 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_191 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_190 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_189 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_188 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_187 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_186 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_185 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_184 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_183 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_182 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_181 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_180 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_179 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_178 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_177 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_176 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_175 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_174 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_173 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_172 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_171 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_170 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_169 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_168 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_167 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_166 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_165 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_164 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_163 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_162 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_161 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_160 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_159 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_158 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_157 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_156 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_155 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_154 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_153 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_152 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_151 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_150 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_149 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_148 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_147 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_146 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_145 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_144 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_143 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_142 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_141 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_140 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_139 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_138 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_137 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_136 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_135 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_107 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_106 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_105 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_104 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_103 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_102 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_101 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_100 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_99 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_98 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_97 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_96 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_95 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_94 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_93 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_92 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_91 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_90 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_89 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_88 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_87 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_86 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_85 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_84 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_83 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_82 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_81 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_80 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_79 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_78 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_77 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_76 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_75 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_74 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_73 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_72 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_71 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_70 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_69 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_68 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_67 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_66 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_65 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_64 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_63 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_62 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_61 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_60 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_59 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_58 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_57 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_56 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_55 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_54 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_53 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_52 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_51 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_50 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_49 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_48 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_47 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_46 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_45 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_44 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_43 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_42 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_41 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_40 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_39 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_38 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_37 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_36 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_35 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_34 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_33 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_32 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_31 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_30 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_29 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_28 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_27 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_26 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_25 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_24 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_23 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_22 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_21 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_20 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_19 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_18 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_17 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_16 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_15 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_14 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_13 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_12 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_11 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_10 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_9 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_8 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_7 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_6 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_5 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_4 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_3 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_2 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_1 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_0 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_134 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_133 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_132 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_131 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_130 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_129 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_128 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_127 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_126 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_125 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_124 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_123 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_122 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_121 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_120 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_119 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_118 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_117 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_116 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_115 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_114 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_113 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_112 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_111 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_110 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_109 As System.Windows.Forms.TextBox
    Public WithEvents _oCol_108 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCT))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.oCol = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.oColDex = New System.Windows.Forms.GroupBox
        Me._oCol_134 = New System.Windows.Forms.TextBox
        Me._oCol_133 = New System.Windows.Forms.TextBox
        Me._oCol_132 = New System.Windows.Forms.TextBox
        Me._oCol_131 = New System.Windows.Forms.TextBox
        Me._oCol_130 = New System.Windows.Forms.TextBox
        Me._oCol_129 = New System.Windows.Forms.TextBox
        Me._oCol_128 = New System.Windows.Forms.TextBox
        Me._oCol_127 = New System.Windows.Forms.TextBox
        Me._oCol_126 = New System.Windows.Forms.TextBox
        Me._oCol_125 = New System.Windows.Forms.TextBox
        Me._oCol_124 = New System.Windows.Forms.TextBox
        Me._oCol_123 = New System.Windows.Forms.TextBox
        Me._oCol_122 = New System.Windows.Forms.TextBox
        Me._oCol_121 = New System.Windows.Forms.TextBox
        Me._oCol_120 = New System.Windows.Forms.TextBox
        Me._oCol_119 = New System.Windows.Forms.TextBox
        Me._oCol_118 = New System.Windows.Forms.TextBox
        Me._oCol_117 = New System.Windows.Forms.TextBox
        Me._oCol_116 = New System.Windows.Forms.TextBox
        Me._oCol_115 = New System.Windows.Forms.TextBox
        Me._oCol_114 = New System.Windows.Forms.TextBox
        Me._oCol_113 = New System.Windows.Forms.TextBox
        Me._oCol_112 = New System.Windows.Forms.TextBox
        Me._oCol_111 = New System.Windows.Forms.TextBox
        Me._oCol_110 = New System.Windows.Forms.TextBox
        Me._oCol_109 = New System.Windows.Forms.TextBox
        Me._oCol_108 = New System.Windows.Forms.TextBox
        Me._oCol_255 = New System.Windows.Forms.TextBox
        Me._oCol_254 = New System.Windows.Forms.TextBox
        Me._oCol_253 = New System.Windows.Forms.TextBox
        Me._oCol_252 = New System.Windows.Forms.TextBox
        Me._oCol_251 = New System.Windows.Forms.TextBox
        Me._oCol_250 = New System.Windows.Forms.TextBox
        Me._oCol_249 = New System.Windows.Forms.TextBox
        Me._oCol_248 = New System.Windows.Forms.TextBox
        Me._oCol_247 = New System.Windows.Forms.TextBox
        Me._oCol_246 = New System.Windows.Forms.TextBox
        Me._oCol_245 = New System.Windows.Forms.TextBox
        Me._oCol_244 = New System.Windows.Forms.TextBox
        Me._oCol_243 = New System.Windows.Forms.TextBox
        Me._oCol_242 = New System.Windows.Forms.TextBox
        Me._oCol_241 = New System.Windows.Forms.TextBox
        Me._oCol_240 = New System.Windows.Forms.TextBox
        Me._oCol_239 = New System.Windows.Forms.TextBox
        Me._oCol_238 = New System.Windows.Forms.TextBox
        Me._oCol_237 = New System.Windows.Forms.TextBox
        Me._oCol_236 = New System.Windows.Forms.TextBox
        Me._oCol_235 = New System.Windows.Forms.TextBox
        Me._oCol_234 = New System.Windows.Forms.TextBox
        Me._oCol_233 = New System.Windows.Forms.TextBox
        Me._oCol_232 = New System.Windows.Forms.TextBox
        Me._oCol_231 = New System.Windows.Forms.TextBox
        Me._oCol_230 = New System.Windows.Forms.TextBox
        Me._oCol_229 = New System.Windows.Forms.TextBox
        Me._oCol_228 = New System.Windows.Forms.TextBox
        Me._oCol_227 = New System.Windows.Forms.TextBox
        Me._oCol_226 = New System.Windows.Forms.TextBox
        Me._oCol_225 = New System.Windows.Forms.TextBox
        Me._oCol_224 = New System.Windows.Forms.TextBox
        Me._oCol_223 = New System.Windows.Forms.TextBox
        Me._oCol_222 = New System.Windows.Forms.TextBox
        Me._oCol_221 = New System.Windows.Forms.TextBox
        Me._oCol_220 = New System.Windows.Forms.TextBox
        Me._oCol_219 = New System.Windows.Forms.TextBox
        Me._oCol_218 = New System.Windows.Forms.TextBox
        Me._oCol_217 = New System.Windows.Forms.TextBox
        Me._oCol_216 = New System.Windows.Forms.TextBox
        Me._oCol_215 = New System.Windows.Forms.TextBox
        Me._oCol_214 = New System.Windows.Forms.TextBox
        Me._oCol_213 = New System.Windows.Forms.TextBox
        Me._oCol_212 = New System.Windows.Forms.TextBox
        Me._oCol_211 = New System.Windows.Forms.TextBox
        Me._oCol_210 = New System.Windows.Forms.TextBox
        Me._oCol_209 = New System.Windows.Forms.TextBox
        Me._oCol_208 = New System.Windows.Forms.TextBox
        Me._oCol_207 = New System.Windows.Forms.TextBox
        Me._oCol_206 = New System.Windows.Forms.TextBox
        Me._oCol_205 = New System.Windows.Forms.TextBox
        Me._oCol_204 = New System.Windows.Forms.TextBox
        Me._oCol_203 = New System.Windows.Forms.TextBox
        Me._oCol_202 = New System.Windows.Forms.TextBox
        Me._oCol_201 = New System.Windows.Forms.TextBox
        Me._oCol_200 = New System.Windows.Forms.TextBox
        Me._oCol_199 = New System.Windows.Forms.TextBox
        Me._oCol_198 = New System.Windows.Forms.TextBox
        Me._oCol_197 = New System.Windows.Forms.TextBox
        Me._oCol_196 = New System.Windows.Forms.TextBox
        Me._oCol_195 = New System.Windows.Forms.TextBox
        Me._oCol_194 = New System.Windows.Forms.TextBox
        Me._oCol_193 = New System.Windows.Forms.TextBox
        Me._oCol_192 = New System.Windows.Forms.TextBox
        Me._oCol_191 = New System.Windows.Forms.TextBox
        Me._oCol_190 = New System.Windows.Forms.TextBox
        Me._oCol_189 = New System.Windows.Forms.TextBox
        Me._oCol_188 = New System.Windows.Forms.TextBox
        Me._oCol_187 = New System.Windows.Forms.TextBox
        Me._oCol_186 = New System.Windows.Forms.TextBox
        Me._oCol_185 = New System.Windows.Forms.TextBox
        Me._oCol_184 = New System.Windows.Forms.TextBox
        Me._oCol_183 = New System.Windows.Forms.TextBox
        Me._oCol_182 = New System.Windows.Forms.TextBox
        Me._oCol_181 = New System.Windows.Forms.TextBox
        Me._oCol_180 = New System.Windows.Forms.TextBox
        Me._oCol_179 = New System.Windows.Forms.TextBox
        Me._oCol_178 = New System.Windows.Forms.TextBox
        Me._oCol_177 = New System.Windows.Forms.TextBox
        Me._oCol_176 = New System.Windows.Forms.TextBox
        Me._oCol_175 = New System.Windows.Forms.TextBox
        Me._oCol_174 = New System.Windows.Forms.TextBox
        Me._oCol_173 = New System.Windows.Forms.TextBox
        Me._oCol_172 = New System.Windows.Forms.TextBox
        Me._oCol_171 = New System.Windows.Forms.TextBox
        Me._oCol_170 = New System.Windows.Forms.TextBox
        Me._oCol_169 = New System.Windows.Forms.TextBox
        Me._oCol_168 = New System.Windows.Forms.TextBox
        Me._oCol_167 = New System.Windows.Forms.TextBox
        Me._oCol_166 = New System.Windows.Forms.TextBox
        Me._oCol_165 = New System.Windows.Forms.TextBox
        Me._oCol_164 = New System.Windows.Forms.TextBox
        Me._oCol_163 = New System.Windows.Forms.TextBox
        Me._oCol_162 = New System.Windows.Forms.TextBox
        Me._oCol_161 = New System.Windows.Forms.TextBox
        Me._oCol_160 = New System.Windows.Forms.TextBox
        Me._oCol_159 = New System.Windows.Forms.TextBox
        Me._oCol_158 = New System.Windows.Forms.TextBox
        Me._oCol_157 = New System.Windows.Forms.TextBox
        Me._oCol_156 = New System.Windows.Forms.TextBox
        Me._oCol_155 = New System.Windows.Forms.TextBox
        Me._oCol_154 = New System.Windows.Forms.TextBox
        Me._oCol_153 = New System.Windows.Forms.TextBox
        Me._oCol_152 = New System.Windows.Forms.TextBox
        Me._oCol_151 = New System.Windows.Forms.TextBox
        Me._oCol_150 = New System.Windows.Forms.TextBox
        Me._oCol_149 = New System.Windows.Forms.TextBox
        Me._oCol_148 = New System.Windows.Forms.TextBox
        Me._oCol_147 = New System.Windows.Forms.TextBox
        Me._oCol_146 = New System.Windows.Forms.TextBox
        Me._oCol_145 = New System.Windows.Forms.TextBox
        Me._oCol_144 = New System.Windows.Forms.TextBox
        Me._oCol_143 = New System.Windows.Forms.TextBox
        Me._oCol_142 = New System.Windows.Forms.TextBox
        Me._oCol_141 = New System.Windows.Forms.TextBox
        Me._oCol_140 = New System.Windows.Forms.TextBox
        Me._oCol_139 = New System.Windows.Forms.TextBox
        Me._oCol_138 = New System.Windows.Forms.TextBox
        Me._oCol_137 = New System.Windows.Forms.TextBox
        Me._oCol_136 = New System.Windows.Forms.TextBox
        Me._oCol_135 = New System.Windows.Forms.TextBox
        Me._oCol_107 = New System.Windows.Forms.TextBox
        Me._oCol_106 = New System.Windows.Forms.TextBox
        Me._oCol_105 = New System.Windows.Forms.TextBox
        Me._oCol_104 = New System.Windows.Forms.TextBox
        Me._oCol_103 = New System.Windows.Forms.TextBox
        Me._oCol_102 = New System.Windows.Forms.TextBox
        Me._oCol_101 = New System.Windows.Forms.TextBox
        Me._oCol_100 = New System.Windows.Forms.TextBox
        Me._oCol_99 = New System.Windows.Forms.TextBox
        Me._oCol_98 = New System.Windows.Forms.TextBox
        Me._oCol_97 = New System.Windows.Forms.TextBox
        Me._oCol_96 = New System.Windows.Forms.TextBox
        Me._oCol_95 = New System.Windows.Forms.TextBox
        Me._oCol_94 = New System.Windows.Forms.TextBox
        Me._oCol_93 = New System.Windows.Forms.TextBox
        Me._oCol_92 = New System.Windows.Forms.TextBox
        Me._oCol_91 = New System.Windows.Forms.TextBox
        Me._oCol_90 = New System.Windows.Forms.TextBox
        Me._oCol_89 = New System.Windows.Forms.TextBox
        Me._oCol_88 = New System.Windows.Forms.TextBox
        Me._oCol_87 = New System.Windows.Forms.TextBox
        Me._oCol_86 = New System.Windows.Forms.TextBox
        Me._oCol_85 = New System.Windows.Forms.TextBox
        Me._oCol_84 = New System.Windows.Forms.TextBox
        Me._oCol_83 = New System.Windows.Forms.TextBox
        Me._oCol_82 = New System.Windows.Forms.TextBox
        Me._oCol_81 = New System.Windows.Forms.TextBox
        Me._oCol_80 = New System.Windows.Forms.TextBox
        Me._oCol_79 = New System.Windows.Forms.TextBox
        Me._oCol_78 = New System.Windows.Forms.TextBox
        Me._oCol_77 = New System.Windows.Forms.TextBox
        Me._oCol_76 = New System.Windows.Forms.TextBox
        Me._oCol_75 = New System.Windows.Forms.TextBox
        Me._oCol_74 = New System.Windows.Forms.TextBox
        Me._oCol_73 = New System.Windows.Forms.TextBox
        Me._oCol_72 = New System.Windows.Forms.TextBox
        Me._oCol_71 = New System.Windows.Forms.TextBox
        Me._oCol_70 = New System.Windows.Forms.TextBox
        Me._oCol_69 = New System.Windows.Forms.TextBox
        Me._oCol_68 = New System.Windows.Forms.TextBox
        Me._oCol_67 = New System.Windows.Forms.TextBox
        Me._oCol_66 = New System.Windows.Forms.TextBox
        Me._oCol_65 = New System.Windows.Forms.TextBox
        Me._oCol_64 = New System.Windows.Forms.TextBox
        Me._oCol_63 = New System.Windows.Forms.TextBox
        Me._oCol_62 = New System.Windows.Forms.TextBox
        Me._oCol_61 = New System.Windows.Forms.TextBox
        Me._oCol_60 = New System.Windows.Forms.TextBox
        Me._oCol_59 = New System.Windows.Forms.TextBox
        Me._oCol_58 = New System.Windows.Forms.TextBox
        Me._oCol_57 = New System.Windows.Forms.TextBox
        Me._oCol_56 = New System.Windows.Forms.TextBox
        Me._oCol_55 = New System.Windows.Forms.TextBox
        Me._oCol_54 = New System.Windows.Forms.TextBox
        Me._oCol_53 = New System.Windows.Forms.TextBox
        Me._oCol_52 = New System.Windows.Forms.TextBox
        Me._oCol_51 = New System.Windows.Forms.TextBox
        Me._oCol_50 = New System.Windows.Forms.TextBox
        Me._oCol_49 = New System.Windows.Forms.TextBox
        Me._oCol_48 = New System.Windows.Forms.TextBox
        Me._oCol_47 = New System.Windows.Forms.TextBox
        Me._oCol_46 = New System.Windows.Forms.TextBox
        Me._oCol_45 = New System.Windows.Forms.TextBox
        Me._oCol_44 = New System.Windows.Forms.TextBox
        Me._oCol_43 = New System.Windows.Forms.TextBox
        Me._oCol_42 = New System.Windows.Forms.TextBox
        Me._oCol_41 = New System.Windows.Forms.TextBox
        Me._oCol_40 = New System.Windows.Forms.TextBox
        Me._oCol_39 = New System.Windows.Forms.TextBox
        Me._oCol_38 = New System.Windows.Forms.TextBox
        Me._oCol_37 = New System.Windows.Forms.TextBox
        Me._oCol_36 = New System.Windows.Forms.TextBox
        Me._oCol_35 = New System.Windows.Forms.TextBox
        Me._oCol_34 = New System.Windows.Forms.TextBox
        Me._oCol_33 = New System.Windows.Forms.TextBox
        Me._oCol_32 = New System.Windows.Forms.TextBox
        Me._oCol_31 = New System.Windows.Forms.TextBox
        Me._oCol_30 = New System.Windows.Forms.TextBox
        Me._oCol_29 = New System.Windows.Forms.TextBox
        Me._oCol_28 = New System.Windows.Forms.TextBox
        Me._oCol_27 = New System.Windows.Forms.TextBox
        Me._oCol_26 = New System.Windows.Forms.TextBox
        Me._oCol_25 = New System.Windows.Forms.TextBox
        Me._oCol_24 = New System.Windows.Forms.TextBox
        Me._oCol_23 = New System.Windows.Forms.TextBox
        Me._oCol_22 = New System.Windows.Forms.TextBox
        Me._oCol_21 = New System.Windows.Forms.TextBox
        Me._oCol_20 = New System.Windows.Forms.TextBox
        Me._oCol_19 = New System.Windows.Forms.TextBox
        Me._oCol_18 = New System.Windows.Forms.TextBox
        Me._oCol_17 = New System.Windows.Forms.TextBox
        Me._oCol_16 = New System.Windows.Forms.TextBox
        Me._oCol_15 = New System.Windows.Forms.TextBox
        Me._oCol_14 = New System.Windows.Forms.TextBox
        Me._oCol_13 = New System.Windows.Forms.TextBox
        Me._oCol_12 = New System.Windows.Forms.TextBox
        Me._oCol_11 = New System.Windows.Forms.TextBox
        Me._oCol_10 = New System.Windows.Forms.TextBox
        Me._oCol_9 = New System.Windows.Forms.TextBox
        Me._oCol_8 = New System.Windows.Forms.TextBox
        Me._oCol_7 = New System.Windows.Forms.TextBox
        Me._oCol_6 = New System.Windows.Forms.TextBox
        Me._oCol_5 = New System.Windows.Forms.TextBox
        Me._oCol_4 = New System.Windows.Forms.TextBox
        Me._oCol_3 = New System.Windows.Forms.TextBox
        Me._oCol_2 = New System.Windows.Forms.TextBox
        Me._oCol_1 = New System.Windows.Forms.TextBox
        Me._oCol_0 = New System.Windows.Forms.TextBox
        CType(Me.oCol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oColDex.SuspendLayout()
        Me.SuspendLayout()
        '
        'oColDex
        '
        Me.oColDex.BackColor = System.Drawing.SystemColors.Control
        Me.oColDex.Controls.Add(Me._oCol_134)
        Me.oColDex.Controls.Add(Me._oCol_133)
        Me.oColDex.Controls.Add(Me._oCol_132)
        Me.oColDex.Controls.Add(Me._oCol_131)
        Me.oColDex.Controls.Add(Me._oCol_130)
        Me.oColDex.Controls.Add(Me._oCol_129)
        Me.oColDex.Controls.Add(Me._oCol_128)
        Me.oColDex.Controls.Add(Me._oCol_127)
        Me.oColDex.Controls.Add(Me._oCol_126)
        Me.oColDex.Controls.Add(Me._oCol_125)
        Me.oColDex.Controls.Add(Me._oCol_124)
        Me.oColDex.Controls.Add(Me._oCol_123)
        Me.oColDex.Controls.Add(Me._oCol_122)
        Me.oColDex.Controls.Add(Me._oCol_121)
        Me.oColDex.Controls.Add(Me._oCol_120)
        Me.oColDex.Controls.Add(Me._oCol_119)
        Me.oColDex.Controls.Add(Me._oCol_118)
        Me.oColDex.Controls.Add(Me._oCol_117)
        Me.oColDex.Controls.Add(Me._oCol_116)
        Me.oColDex.Controls.Add(Me._oCol_115)
        Me.oColDex.Controls.Add(Me._oCol_114)
        Me.oColDex.Controls.Add(Me._oCol_113)
        Me.oColDex.Controls.Add(Me._oCol_112)
        Me.oColDex.Controls.Add(Me._oCol_111)
        Me.oColDex.Controls.Add(Me._oCol_110)
        Me.oColDex.Controls.Add(Me._oCol_109)
        Me.oColDex.Controls.Add(Me._oCol_108)
        Me.oColDex.Controls.Add(Me._oCol_255)
        Me.oColDex.Controls.Add(Me._oCol_254)
        Me.oColDex.Controls.Add(Me._oCol_253)
        Me.oColDex.Controls.Add(Me._oCol_252)
        Me.oColDex.Controls.Add(Me._oCol_251)
        Me.oColDex.Controls.Add(Me._oCol_250)
        Me.oColDex.Controls.Add(Me._oCol_249)
        Me.oColDex.Controls.Add(Me._oCol_248)
        Me.oColDex.Controls.Add(Me._oCol_247)
        Me.oColDex.Controls.Add(Me._oCol_246)
        Me.oColDex.Controls.Add(Me._oCol_245)
        Me.oColDex.Controls.Add(Me._oCol_244)
        Me.oColDex.Controls.Add(Me._oCol_243)
        Me.oColDex.Controls.Add(Me._oCol_242)
        Me.oColDex.Controls.Add(Me._oCol_241)
        Me.oColDex.Controls.Add(Me._oCol_240)
        Me.oColDex.Controls.Add(Me._oCol_239)
        Me.oColDex.Controls.Add(Me._oCol_238)
        Me.oColDex.Controls.Add(Me._oCol_237)
        Me.oColDex.Controls.Add(Me._oCol_236)
        Me.oColDex.Controls.Add(Me._oCol_235)
        Me.oColDex.Controls.Add(Me._oCol_234)
        Me.oColDex.Controls.Add(Me._oCol_233)
        Me.oColDex.Controls.Add(Me._oCol_232)
        Me.oColDex.Controls.Add(Me._oCol_231)
        Me.oColDex.Controls.Add(Me._oCol_230)
        Me.oColDex.Controls.Add(Me._oCol_229)
        Me.oColDex.Controls.Add(Me._oCol_228)
        Me.oColDex.Controls.Add(Me._oCol_227)
        Me.oColDex.Controls.Add(Me._oCol_226)
        Me.oColDex.Controls.Add(Me._oCol_225)
        Me.oColDex.Controls.Add(Me._oCol_224)
        Me.oColDex.Controls.Add(Me._oCol_223)
        Me.oColDex.Controls.Add(Me._oCol_222)
        Me.oColDex.Controls.Add(Me._oCol_221)
        Me.oColDex.Controls.Add(Me._oCol_220)
        Me.oColDex.Controls.Add(Me._oCol_219)
        Me.oColDex.Controls.Add(Me._oCol_218)
        Me.oColDex.Controls.Add(Me._oCol_217)
        Me.oColDex.Controls.Add(Me._oCol_216)
        Me.oColDex.Controls.Add(Me._oCol_215)
        Me.oColDex.Controls.Add(Me._oCol_214)
        Me.oColDex.Controls.Add(Me._oCol_213)
        Me.oColDex.Controls.Add(Me._oCol_212)
        Me.oColDex.Controls.Add(Me._oCol_211)
        Me.oColDex.Controls.Add(Me._oCol_210)
        Me.oColDex.Controls.Add(Me._oCol_209)
        Me.oColDex.Controls.Add(Me._oCol_208)
        Me.oColDex.Controls.Add(Me._oCol_207)
        Me.oColDex.Controls.Add(Me._oCol_206)
        Me.oColDex.Controls.Add(Me._oCol_205)
        Me.oColDex.Controls.Add(Me._oCol_204)
        Me.oColDex.Controls.Add(Me._oCol_203)
        Me.oColDex.Controls.Add(Me._oCol_202)
        Me.oColDex.Controls.Add(Me._oCol_201)
        Me.oColDex.Controls.Add(Me._oCol_200)
        Me.oColDex.Controls.Add(Me._oCol_199)
        Me.oColDex.Controls.Add(Me._oCol_198)
        Me.oColDex.Controls.Add(Me._oCol_197)
        Me.oColDex.Controls.Add(Me._oCol_196)
        Me.oColDex.Controls.Add(Me._oCol_195)
        Me.oColDex.Controls.Add(Me._oCol_194)
        Me.oColDex.Controls.Add(Me._oCol_193)
        Me.oColDex.Controls.Add(Me._oCol_192)
        Me.oColDex.Controls.Add(Me._oCol_191)
        Me.oColDex.Controls.Add(Me._oCol_190)
        Me.oColDex.Controls.Add(Me._oCol_189)
        Me.oColDex.Controls.Add(Me._oCol_188)
        Me.oColDex.Controls.Add(Me._oCol_187)
        Me.oColDex.Controls.Add(Me._oCol_186)
        Me.oColDex.Controls.Add(Me._oCol_185)
        Me.oColDex.Controls.Add(Me._oCol_184)
        Me.oColDex.Controls.Add(Me._oCol_183)
        Me.oColDex.Controls.Add(Me._oCol_182)
        Me.oColDex.Controls.Add(Me._oCol_181)
        Me.oColDex.Controls.Add(Me._oCol_180)
        Me.oColDex.Controls.Add(Me._oCol_179)
        Me.oColDex.Controls.Add(Me._oCol_178)
        Me.oColDex.Controls.Add(Me._oCol_177)
        Me.oColDex.Controls.Add(Me._oCol_176)
        Me.oColDex.Controls.Add(Me._oCol_175)
        Me.oColDex.Controls.Add(Me._oCol_174)
        Me.oColDex.Controls.Add(Me._oCol_173)
        Me.oColDex.Controls.Add(Me._oCol_172)
        Me.oColDex.Controls.Add(Me._oCol_171)
        Me.oColDex.Controls.Add(Me._oCol_170)
        Me.oColDex.Controls.Add(Me._oCol_169)
        Me.oColDex.Controls.Add(Me._oCol_168)
        Me.oColDex.Controls.Add(Me._oCol_167)
        Me.oColDex.Controls.Add(Me._oCol_166)
        Me.oColDex.Controls.Add(Me._oCol_165)
        Me.oColDex.Controls.Add(Me._oCol_164)
        Me.oColDex.Controls.Add(Me._oCol_163)
        Me.oColDex.Controls.Add(Me._oCol_162)
        Me.oColDex.Controls.Add(Me._oCol_161)
        Me.oColDex.Controls.Add(Me._oCol_160)
        Me.oColDex.Controls.Add(Me._oCol_159)
        Me.oColDex.Controls.Add(Me._oCol_158)
        Me.oColDex.Controls.Add(Me._oCol_157)
        Me.oColDex.Controls.Add(Me._oCol_156)
        Me.oColDex.Controls.Add(Me._oCol_155)
        Me.oColDex.Controls.Add(Me._oCol_154)
        Me.oColDex.Controls.Add(Me._oCol_153)
        Me.oColDex.Controls.Add(Me._oCol_152)
        Me.oColDex.Controls.Add(Me._oCol_151)
        Me.oColDex.Controls.Add(Me._oCol_150)
        Me.oColDex.Controls.Add(Me._oCol_149)
        Me.oColDex.Controls.Add(Me._oCol_148)
        Me.oColDex.Controls.Add(Me._oCol_147)
        Me.oColDex.Controls.Add(Me._oCol_146)
        Me.oColDex.Controls.Add(Me._oCol_145)
        Me.oColDex.Controls.Add(Me._oCol_144)
        Me.oColDex.Controls.Add(Me._oCol_143)
        Me.oColDex.Controls.Add(Me._oCol_142)
        Me.oColDex.Controls.Add(Me._oCol_141)
        Me.oColDex.Controls.Add(Me._oCol_140)
        Me.oColDex.Controls.Add(Me._oCol_139)
        Me.oColDex.Controls.Add(Me._oCol_138)
        Me.oColDex.Controls.Add(Me._oCol_137)
        Me.oColDex.Controls.Add(Me._oCol_136)
        Me.oColDex.Controls.Add(Me._oCol_135)
        Me.oColDex.Controls.Add(Me._oCol_107)
        Me.oColDex.Controls.Add(Me._oCol_106)
        Me.oColDex.Controls.Add(Me._oCol_105)
        Me.oColDex.Controls.Add(Me._oCol_104)
        Me.oColDex.Controls.Add(Me._oCol_103)
        Me.oColDex.Controls.Add(Me._oCol_102)
        Me.oColDex.Controls.Add(Me._oCol_101)
        Me.oColDex.Controls.Add(Me._oCol_100)
        Me.oColDex.Controls.Add(Me._oCol_99)
        Me.oColDex.Controls.Add(Me._oCol_98)
        Me.oColDex.Controls.Add(Me._oCol_97)
        Me.oColDex.Controls.Add(Me._oCol_96)
        Me.oColDex.Controls.Add(Me._oCol_95)
        Me.oColDex.Controls.Add(Me._oCol_94)
        Me.oColDex.Controls.Add(Me._oCol_93)
        Me.oColDex.Controls.Add(Me._oCol_92)
        Me.oColDex.Controls.Add(Me._oCol_91)
        Me.oColDex.Controls.Add(Me._oCol_90)
        Me.oColDex.Controls.Add(Me._oCol_89)
        Me.oColDex.Controls.Add(Me._oCol_88)
        Me.oColDex.Controls.Add(Me._oCol_87)
        Me.oColDex.Controls.Add(Me._oCol_86)
        Me.oColDex.Controls.Add(Me._oCol_85)
        Me.oColDex.Controls.Add(Me._oCol_84)
        Me.oColDex.Controls.Add(Me._oCol_83)
        Me.oColDex.Controls.Add(Me._oCol_82)
        Me.oColDex.Controls.Add(Me._oCol_81)
        Me.oColDex.Controls.Add(Me._oCol_80)
        Me.oColDex.Controls.Add(Me._oCol_79)
        Me.oColDex.Controls.Add(Me._oCol_78)
        Me.oColDex.Controls.Add(Me._oCol_77)
        Me.oColDex.Controls.Add(Me._oCol_76)
        Me.oColDex.Controls.Add(Me._oCol_75)
        Me.oColDex.Controls.Add(Me._oCol_74)
        Me.oColDex.Controls.Add(Me._oCol_73)
        Me.oColDex.Controls.Add(Me._oCol_72)
        Me.oColDex.Controls.Add(Me._oCol_71)
        Me.oColDex.Controls.Add(Me._oCol_70)
        Me.oColDex.Controls.Add(Me._oCol_69)
        Me.oColDex.Controls.Add(Me._oCol_68)
        Me.oColDex.Controls.Add(Me._oCol_67)
        Me.oColDex.Controls.Add(Me._oCol_66)
        Me.oColDex.Controls.Add(Me._oCol_65)
        Me.oColDex.Controls.Add(Me._oCol_64)
        Me.oColDex.Controls.Add(Me._oCol_63)
        Me.oColDex.Controls.Add(Me._oCol_62)
        Me.oColDex.Controls.Add(Me._oCol_61)
        Me.oColDex.Controls.Add(Me._oCol_60)
        Me.oColDex.Controls.Add(Me._oCol_59)
        Me.oColDex.Controls.Add(Me._oCol_58)
        Me.oColDex.Controls.Add(Me._oCol_57)
        Me.oColDex.Controls.Add(Me._oCol_56)
        Me.oColDex.Controls.Add(Me._oCol_55)
        Me.oColDex.Controls.Add(Me._oCol_54)
        Me.oColDex.Controls.Add(Me._oCol_53)
        Me.oColDex.Controls.Add(Me._oCol_52)
        Me.oColDex.Controls.Add(Me._oCol_51)
        Me.oColDex.Controls.Add(Me._oCol_50)
        Me.oColDex.Controls.Add(Me._oCol_49)
        Me.oColDex.Controls.Add(Me._oCol_48)
        Me.oColDex.Controls.Add(Me._oCol_47)
        Me.oColDex.Controls.Add(Me._oCol_46)
        Me.oColDex.Controls.Add(Me._oCol_45)
        Me.oColDex.Controls.Add(Me._oCol_44)
        Me.oColDex.Controls.Add(Me._oCol_43)
        Me.oColDex.Controls.Add(Me._oCol_42)
        Me.oColDex.Controls.Add(Me._oCol_41)
        Me.oColDex.Controls.Add(Me._oCol_40)
        Me.oColDex.Controls.Add(Me._oCol_39)
        Me.oColDex.Controls.Add(Me._oCol_38)
        Me.oColDex.Controls.Add(Me._oCol_37)
        Me.oColDex.Controls.Add(Me._oCol_36)
        Me.oColDex.Controls.Add(Me._oCol_35)
        Me.oColDex.Controls.Add(Me._oCol_34)
        Me.oColDex.Controls.Add(Me._oCol_33)
        Me.oColDex.Controls.Add(Me._oCol_32)
        Me.oColDex.Controls.Add(Me._oCol_31)
        Me.oColDex.Controls.Add(Me._oCol_30)
        Me.oColDex.Controls.Add(Me._oCol_29)
        Me.oColDex.Controls.Add(Me._oCol_28)
        Me.oColDex.Controls.Add(Me._oCol_27)
        Me.oColDex.Controls.Add(Me._oCol_26)
        Me.oColDex.Controls.Add(Me._oCol_25)
        Me.oColDex.Controls.Add(Me._oCol_24)
        Me.oColDex.Controls.Add(Me._oCol_23)
        Me.oColDex.Controls.Add(Me._oCol_22)
        Me.oColDex.Controls.Add(Me._oCol_21)
        Me.oColDex.Controls.Add(Me._oCol_20)
        Me.oColDex.Controls.Add(Me._oCol_19)
        Me.oColDex.Controls.Add(Me._oCol_18)
        Me.oColDex.Controls.Add(Me._oCol_17)
        Me.oColDex.Controls.Add(Me._oCol_16)
        Me.oColDex.Controls.Add(Me._oCol_15)
        Me.oColDex.Controls.Add(Me._oCol_14)
        Me.oColDex.Controls.Add(Me._oCol_13)
        Me.oColDex.Controls.Add(Me._oCol_12)
        Me.oColDex.Controls.Add(Me._oCol_11)
        Me.oColDex.Controls.Add(Me._oCol_10)
        Me.oColDex.Controls.Add(Me._oCol_9)
        Me.oColDex.Controls.Add(Me._oCol_8)
        Me.oColDex.Controls.Add(Me._oCol_7)
        Me.oColDex.Controls.Add(Me._oCol_6)
        Me.oColDex.Controls.Add(Me._oCol_5)
        Me.oColDex.Controls.Add(Me._oCol_4)
        Me.oColDex.Controls.Add(Me._oCol_3)
        Me.oColDex.Controls.Add(Me._oCol_2)
        Me.oColDex.Controls.Add(Me._oCol_1)
        Me.oColDex.Controls.Add(Me._oCol_0)
        Me.oColDex.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oColDex.ForeColor = System.Drawing.SystemColors.ControlText
        Me.oColDex.Location = New System.Drawing.Point(8, 8)
        Me.oColDex.Name = "oColDex"
        Me.oColDex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.oColDex.Size = New System.Drawing.Size(449, 263)
        Me.oColDex.TabIndex = 15
        Me.oColDex.TabStop = False
        Me.oColDex.Text = "Color Table"
        '
        '_oCol_134
        '
        Me._oCol_134.AcceptsReturn = True
        Me._oCol_134.AutoSize = False
        Me._oCol_134.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_134.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_134.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_134.Enabled = False
        Me._oCol_134.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_134.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_134.Location = New System.Drawing.Point(424, 112)
        Me._oCol_134.MaxLength = 0
        Me._oCol_134.Name = "_oCol_134"
        Me._oCol_134.ReadOnly = True
        Me._oCol_134.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_134.Size = New System.Drawing.Size(17, 25)
        Me._oCol_134.TabIndex = 303
        Me._oCol_134.Text = ""
        '
        '_oCol_133
        '
        Me._oCol_133.AcceptsReturn = True
        Me._oCol_133.AutoSize = False
        Me._oCol_133.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_133.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_133.Enabled = False
        Me._oCol_133.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_133.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_133.Location = New System.Drawing.Point(408, 112)
        Me._oCol_133.MaxLength = 0
        Me._oCol_133.Name = "_oCol_133"
        Me._oCol_133.ReadOnly = True
        Me._oCol_133.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_133.Size = New System.Drawing.Size(17, 25)
        Me._oCol_133.TabIndex = 302
        Me._oCol_133.Text = ""
        '
        '_oCol_132
        '
        Me._oCol_132.AcceptsReturn = True
        Me._oCol_132.AutoSize = False
        Me._oCol_132.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_132.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_132.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_132.Enabled = False
        Me._oCol_132.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_132.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_132.Location = New System.Drawing.Point(392, 112)
        Me._oCol_132.MaxLength = 0
        Me._oCol_132.Name = "_oCol_132"
        Me._oCol_132.ReadOnly = True
        Me._oCol_132.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_132.Size = New System.Drawing.Size(17, 25)
        Me._oCol_132.TabIndex = 301
        Me._oCol_132.Text = ""
        '
        '_oCol_131
        '
        Me._oCol_131.AcceptsReturn = True
        Me._oCol_131.AutoSize = False
        Me._oCol_131.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_131.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_131.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_131.Enabled = False
        Me._oCol_131.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_131.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_131.Location = New System.Drawing.Point(376, 112)
        Me._oCol_131.MaxLength = 0
        Me._oCol_131.Name = "_oCol_131"
        Me._oCol_131.ReadOnly = True
        Me._oCol_131.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_131.Size = New System.Drawing.Size(17, 25)
        Me._oCol_131.TabIndex = 300
        Me._oCol_131.Text = ""
        '
        '_oCol_130
        '
        Me._oCol_130.AcceptsReturn = True
        Me._oCol_130.AutoSize = False
        Me._oCol_130.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_130.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_130.Enabled = False
        Me._oCol_130.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_130.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_130.Location = New System.Drawing.Point(360, 112)
        Me._oCol_130.MaxLength = 0
        Me._oCol_130.Name = "_oCol_130"
        Me._oCol_130.ReadOnly = True
        Me._oCol_130.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_130.Size = New System.Drawing.Size(17, 25)
        Me._oCol_130.TabIndex = 299
        Me._oCol_130.Text = ""
        '
        '_oCol_129
        '
        Me._oCol_129.AcceptsReturn = True
        Me._oCol_129.AutoSize = False
        Me._oCol_129.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_129.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_129.Enabled = False
        Me._oCol_129.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_129.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_129.Location = New System.Drawing.Point(344, 112)
        Me._oCol_129.MaxLength = 0
        Me._oCol_129.Name = "_oCol_129"
        Me._oCol_129.ReadOnly = True
        Me._oCol_129.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_129.Size = New System.Drawing.Size(17, 25)
        Me._oCol_129.TabIndex = 298
        Me._oCol_129.Text = ""
        '
        '_oCol_128
        '
        Me._oCol_128.AcceptsReturn = True
        Me._oCol_128.AutoSize = False
        Me._oCol_128.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_128.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_128.Enabled = False
        Me._oCol_128.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_128.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_128.Location = New System.Drawing.Point(328, 112)
        Me._oCol_128.MaxLength = 0
        Me._oCol_128.Name = "_oCol_128"
        Me._oCol_128.ReadOnly = True
        Me._oCol_128.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_128.Size = New System.Drawing.Size(17, 25)
        Me._oCol_128.TabIndex = 297
        Me._oCol_128.Text = ""
        '
        '_oCol_127
        '
        Me._oCol_127.AcceptsReturn = True
        Me._oCol_127.AutoSize = False
        Me._oCol_127.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_127.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_127.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_127.Enabled = False
        Me._oCol_127.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_127.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_127.Location = New System.Drawing.Point(312, 112)
        Me._oCol_127.MaxLength = 0
        Me._oCol_127.Name = "_oCol_127"
        Me._oCol_127.ReadOnly = True
        Me._oCol_127.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_127.Size = New System.Drawing.Size(17, 25)
        Me._oCol_127.TabIndex = 296
        Me._oCol_127.Text = ""
        '
        '_oCol_126
        '
        Me._oCol_126.AcceptsReturn = True
        Me._oCol_126.AutoSize = False
        Me._oCol_126.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_126.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_126.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_126.Enabled = False
        Me._oCol_126.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_126.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_126.Location = New System.Drawing.Point(296, 112)
        Me._oCol_126.MaxLength = 0
        Me._oCol_126.Name = "_oCol_126"
        Me._oCol_126.ReadOnly = True
        Me._oCol_126.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_126.Size = New System.Drawing.Size(17, 25)
        Me._oCol_126.TabIndex = 295
        Me._oCol_126.Text = ""
        '
        '_oCol_125
        '
        Me._oCol_125.AcceptsReturn = True
        Me._oCol_125.AutoSize = False
        Me._oCol_125.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_125.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_125.Enabled = False
        Me._oCol_125.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_125.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_125.Location = New System.Drawing.Point(280, 112)
        Me._oCol_125.MaxLength = 0
        Me._oCol_125.Name = "_oCol_125"
        Me._oCol_125.ReadOnly = True
        Me._oCol_125.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_125.Size = New System.Drawing.Size(17, 25)
        Me._oCol_125.TabIndex = 294
        Me._oCol_125.Text = ""
        '
        '_oCol_124
        '
        Me._oCol_124.AcceptsReturn = True
        Me._oCol_124.AutoSize = False
        Me._oCol_124.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_124.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_124.Enabled = False
        Me._oCol_124.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_124.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_124.Location = New System.Drawing.Point(264, 112)
        Me._oCol_124.MaxLength = 0
        Me._oCol_124.Name = "_oCol_124"
        Me._oCol_124.ReadOnly = True
        Me._oCol_124.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_124.Size = New System.Drawing.Size(17, 25)
        Me._oCol_124.TabIndex = 293
        Me._oCol_124.Text = ""
        '
        '_oCol_123
        '
        Me._oCol_123.AcceptsReturn = True
        Me._oCol_123.AutoSize = False
        Me._oCol_123.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_123.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_123.Enabled = False
        Me._oCol_123.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_123.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_123.Location = New System.Drawing.Point(248, 112)
        Me._oCol_123.MaxLength = 0
        Me._oCol_123.Name = "_oCol_123"
        Me._oCol_123.ReadOnly = True
        Me._oCol_123.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_123.Size = New System.Drawing.Size(17, 25)
        Me._oCol_123.TabIndex = 292
        Me._oCol_123.Text = ""
        '
        '_oCol_122
        '
        Me._oCol_122.AcceptsReturn = True
        Me._oCol_122.AutoSize = False
        Me._oCol_122.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_122.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_122.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_122.Enabled = False
        Me._oCol_122.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_122.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_122.Location = New System.Drawing.Point(232, 112)
        Me._oCol_122.MaxLength = 0
        Me._oCol_122.Name = "_oCol_122"
        Me._oCol_122.ReadOnly = True
        Me._oCol_122.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_122.Size = New System.Drawing.Size(17, 25)
        Me._oCol_122.TabIndex = 291
        Me._oCol_122.Text = ""
        '
        '_oCol_121
        '
        Me._oCol_121.AcceptsReturn = True
        Me._oCol_121.AutoSize = False
        Me._oCol_121.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_121.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_121.Enabled = False
        Me._oCol_121.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_121.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_121.Location = New System.Drawing.Point(216, 112)
        Me._oCol_121.MaxLength = 0
        Me._oCol_121.Name = "_oCol_121"
        Me._oCol_121.ReadOnly = True
        Me._oCol_121.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_121.Size = New System.Drawing.Size(17, 25)
        Me._oCol_121.TabIndex = 290
        Me._oCol_121.Text = ""
        '
        '_oCol_120
        '
        Me._oCol_120.AcceptsReturn = True
        Me._oCol_120.AutoSize = False
        Me._oCol_120.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_120.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_120.Enabled = False
        Me._oCol_120.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_120.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_120.Location = New System.Drawing.Point(200, 112)
        Me._oCol_120.MaxLength = 0
        Me._oCol_120.Name = "_oCol_120"
        Me._oCol_120.ReadOnly = True
        Me._oCol_120.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_120.Size = New System.Drawing.Size(17, 25)
        Me._oCol_120.TabIndex = 289
        Me._oCol_120.Text = ""
        '
        '_oCol_119
        '
        Me._oCol_119.AcceptsReturn = True
        Me._oCol_119.AutoSize = False
        Me._oCol_119.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_119.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_119.Enabled = False
        Me._oCol_119.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_119.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_119.Location = New System.Drawing.Point(184, 112)
        Me._oCol_119.MaxLength = 0
        Me._oCol_119.Name = "_oCol_119"
        Me._oCol_119.ReadOnly = True
        Me._oCol_119.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_119.Size = New System.Drawing.Size(17, 25)
        Me._oCol_119.TabIndex = 288
        Me._oCol_119.Text = ""
        '
        '_oCol_118
        '
        Me._oCol_118.AcceptsReturn = True
        Me._oCol_118.AutoSize = False
        Me._oCol_118.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_118.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_118.Enabled = False
        Me._oCol_118.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_118.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_118.Location = New System.Drawing.Point(168, 112)
        Me._oCol_118.MaxLength = 0
        Me._oCol_118.Name = "_oCol_118"
        Me._oCol_118.ReadOnly = True
        Me._oCol_118.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_118.Size = New System.Drawing.Size(17, 25)
        Me._oCol_118.TabIndex = 287
        Me._oCol_118.Text = ""
        '
        '_oCol_117
        '
        Me._oCol_117.AcceptsReturn = True
        Me._oCol_117.AutoSize = False
        Me._oCol_117.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_117.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_117.Enabled = False
        Me._oCol_117.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_117.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_117.Location = New System.Drawing.Point(152, 112)
        Me._oCol_117.MaxLength = 0
        Me._oCol_117.Name = "_oCol_117"
        Me._oCol_117.ReadOnly = True
        Me._oCol_117.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_117.Size = New System.Drawing.Size(17, 25)
        Me._oCol_117.TabIndex = 286
        Me._oCol_117.Text = ""
        '
        '_oCol_116
        '
        Me._oCol_116.AcceptsReturn = True
        Me._oCol_116.AutoSize = False
        Me._oCol_116.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_116.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_116.Enabled = False
        Me._oCol_116.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_116.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_116.Location = New System.Drawing.Point(136, 112)
        Me._oCol_116.MaxLength = 0
        Me._oCol_116.Name = "_oCol_116"
        Me._oCol_116.ReadOnly = True
        Me._oCol_116.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_116.Size = New System.Drawing.Size(17, 25)
        Me._oCol_116.TabIndex = 285
        Me._oCol_116.Text = ""
        '
        '_oCol_115
        '
        Me._oCol_115.AcceptsReturn = True
        Me._oCol_115.AutoSize = False
        Me._oCol_115.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_115.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_115.Enabled = False
        Me._oCol_115.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_115.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_115.Location = New System.Drawing.Point(120, 112)
        Me._oCol_115.MaxLength = 0
        Me._oCol_115.Name = "_oCol_115"
        Me._oCol_115.ReadOnly = True
        Me._oCol_115.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_115.Size = New System.Drawing.Size(17, 25)
        Me._oCol_115.TabIndex = 284
        Me._oCol_115.Text = ""
        '
        '_oCol_114
        '
        Me._oCol_114.AcceptsReturn = True
        Me._oCol_114.AutoSize = False
        Me._oCol_114.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_114.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_114.Enabled = False
        Me._oCol_114.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_114.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_114.Location = New System.Drawing.Point(104, 112)
        Me._oCol_114.MaxLength = 0
        Me._oCol_114.Name = "_oCol_114"
        Me._oCol_114.ReadOnly = True
        Me._oCol_114.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_114.Size = New System.Drawing.Size(17, 25)
        Me._oCol_114.TabIndex = 283
        Me._oCol_114.Text = ""
        '
        '_oCol_113
        '
        Me._oCol_113.AcceptsReturn = True
        Me._oCol_113.AutoSize = False
        Me._oCol_113.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_113.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_113.Enabled = False
        Me._oCol_113.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_113.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_113.Location = New System.Drawing.Point(88, 112)
        Me._oCol_113.MaxLength = 0
        Me._oCol_113.Name = "_oCol_113"
        Me._oCol_113.ReadOnly = True
        Me._oCol_113.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_113.Size = New System.Drawing.Size(17, 25)
        Me._oCol_113.TabIndex = 282
        Me._oCol_113.Text = ""
        '
        '_oCol_112
        '
        Me._oCol_112.AcceptsReturn = True
        Me._oCol_112.AutoSize = False
        Me._oCol_112.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_112.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_112.Enabled = False
        Me._oCol_112.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_112.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_112.Location = New System.Drawing.Point(72, 112)
        Me._oCol_112.MaxLength = 0
        Me._oCol_112.Name = "_oCol_112"
        Me._oCol_112.ReadOnly = True
        Me._oCol_112.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_112.Size = New System.Drawing.Size(17, 25)
        Me._oCol_112.TabIndex = 281
        Me._oCol_112.Text = ""
        '
        '_oCol_111
        '
        Me._oCol_111.AcceptsReturn = True
        Me._oCol_111.AutoSize = False
        Me._oCol_111.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_111.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_111.Enabled = False
        Me._oCol_111.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_111.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_111.Location = New System.Drawing.Point(56, 112)
        Me._oCol_111.MaxLength = 0
        Me._oCol_111.Name = "_oCol_111"
        Me._oCol_111.ReadOnly = True
        Me._oCol_111.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_111.Size = New System.Drawing.Size(17, 25)
        Me._oCol_111.TabIndex = 280
        Me._oCol_111.Text = ""
        '
        '_oCol_110
        '
        Me._oCol_110.AcceptsReturn = True
        Me._oCol_110.AutoSize = False
        Me._oCol_110.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_110.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_110.Enabled = False
        Me._oCol_110.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_110.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_110.Location = New System.Drawing.Point(40, 112)
        Me._oCol_110.MaxLength = 0
        Me._oCol_110.Name = "_oCol_110"
        Me._oCol_110.ReadOnly = True
        Me._oCol_110.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_110.Size = New System.Drawing.Size(17, 25)
        Me._oCol_110.TabIndex = 279
        Me._oCol_110.Text = ""
        '
        '_oCol_109
        '
        Me._oCol_109.AcceptsReturn = True
        Me._oCol_109.AutoSize = False
        Me._oCol_109.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_109.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_109.Enabled = False
        Me._oCol_109.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_109.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_109.Location = New System.Drawing.Point(24, 112)
        Me._oCol_109.MaxLength = 0
        Me._oCol_109.Name = "_oCol_109"
        Me._oCol_109.ReadOnly = True
        Me._oCol_109.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_109.Size = New System.Drawing.Size(17, 25)
        Me._oCol_109.TabIndex = 278
        Me._oCol_109.Text = ""
        '
        '_oCol_108
        '
        Me._oCol_108.AcceptsReturn = True
        Me._oCol_108.AutoSize = False
        Me._oCol_108.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_108.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_108.Enabled = False
        Me._oCol_108.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_108.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_108.Location = New System.Drawing.Point(8, 112)
        Me._oCol_108.MaxLength = 0
        Me._oCol_108.Name = "_oCol_108"
        Me._oCol_108.ReadOnly = True
        Me._oCol_108.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_108.Size = New System.Drawing.Size(17, 25)
        Me._oCol_108.TabIndex = 277
        Me._oCol_108.Text = ""
        '
        '_oCol_255
        '
        Me._oCol_255.AcceptsReturn = True
        Me._oCol_255.AutoSize = False
        Me._oCol_255.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_255.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_255.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_255.Enabled = False
        Me._oCol_255.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_255.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_255.Location = New System.Drawing.Point(200, 232)
        Me._oCol_255.MaxLength = 0
        Me._oCol_255.Name = "_oCol_255"
        Me._oCol_255.ReadOnly = True
        Me._oCol_255.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_255.Size = New System.Drawing.Size(17, 25)
        Me._oCol_255.TabIndex = 276
        Me._oCol_255.Text = ""
        '
        '_oCol_254
        '
        Me._oCol_254.AcceptsReturn = True
        Me._oCol_254.AutoSize = False
        Me._oCol_254.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_254.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_254.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_254.Enabled = False
        Me._oCol_254.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_254.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_254.Location = New System.Drawing.Point(184, 232)
        Me._oCol_254.MaxLength = 0
        Me._oCol_254.Name = "_oCol_254"
        Me._oCol_254.ReadOnly = True
        Me._oCol_254.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_254.Size = New System.Drawing.Size(17, 25)
        Me._oCol_254.TabIndex = 275
        Me._oCol_254.Text = ""
        '
        '_oCol_253
        '
        Me._oCol_253.AcceptsReturn = True
        Me._oCol_253.AutoSize = False
        Me._oCol_253.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_253.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_253.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_253.Enabled = False
        Me._oCol_253.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_253.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_253.Location = New System.Drawing.Point(168, 232)
        Me._oCol_253.MaxLength = 0
        Me._oCol_253.Name = "_oCol_253"
        Me._oCol_253.ReadOnly = True
        Me._oCol_253.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_253.Size = New System.Drawing.Size(17, 25)
        Me._oCol_253.TabIndex = 274
        Me._oCol_253.Text = ""
        '
        '_oCol_252
        '
        Me._oCol_252.AcceptsReturn = True
        Me._oCol_252.AutoSize = False
        Me._oCol_252.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_252.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_252.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_252.Enabled = False
        Me._oCol_252.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_252.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_252.Location = New System.Drawing.Point(152, 232)
        Me._oCol_252.MaxLength = 0
        Me._oCol_252.Name = "_oCol_252"
        Me._oCol_252.ReadOnly = True
        Me._oCol_252.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_252.Size = New System.Drawing.Size(17, 25)
        Me._oCol_252.TabIndex = 273
        Me._oCol_252.Text = ""
        '
        '_oCol_251
        '
        Me._oCol_251.AcceptsReturn = True
        Me._oCol_251.AutoSize = False
        Me._oCol_251.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_251.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_251.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_251.Enabled = False
        Me._oCol_251.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_251.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_251.Location = New System.Drawing.Point(136, 232)
        Me._oCol_251.MaxLength = 0
        Me._oCol_251.Name = "_oCol_251"
        Me._oCol_251.ReadOnly = True
        Me._oCol_251.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_251.Size = New System.Drawing.Size(17, 25)
        Me._oCol_251.TabIndex = 272
        Me._oCol_251.Text = ""
        '
        '_oCol_250
        '
        Me._oCol_250.AcceptsReturn = True
        Me._oCol_250.AutoSize = False
        Me._oCol_250.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_250.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_250.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_250.Enabled = False
        Me._oCol_250.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_250.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_250.Location = New System.Drawing.Point(120, 232)
        Me._oCol_250.MaxLength = 0
        Me._oCol_250.Name = "_oCol_250"
        Me._oCol_250.ReadOnly = True
        Me._oCol_250.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_250.Size = New System.Drawing.Size(17, 25)
        Me._oCol_250.TabIndex = 271
        Me._oCol_250.Text = ""
        '
        '_oCol_249
        '
        Me._oCol_249.AcceptsReturn = True
        Me._oCol_249.AutoSize = False
        Me._oCol_249.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_249.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_249.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_249.Enabled = False
        Me._oCol_249.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_249.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_249.Location = New System.Drawing.Point(104, 232)
        Me._oCol_249.MaxLength = 0
        Me._oCol_249.Name = "_oCol_249"
        Me._oCol_249.ReadOnly = True
        Me._oCol_249.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_249.Size = New System.Drawing.Size(17, 25)
        Me._oCol_249.TabIndex = 270
        Me._oCol_249.Text = ""
        '
        '_oCol_248
        '
        Me._oCol_248.AcceptsReturn = True
        Me._oCol_248.AutoSize = False
        Me._oCol_248.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_248.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_248.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_248.Enabled = False
        Me._oCol_248.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_248.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_248.Location = New System.Drawing.Point(88, 232)
        Me._oCol_248.MaxLength = 0
        Me._oCol_248.Name = "_oCol_248"
        Me._oCol_248.ReadOnly = True
        Me._oCol_248.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_248.Size = New System.Drawing.Size(17, 25)
        Me._oCol_248.TabIndex = 269
        Me._oCol_248.Text = ""
        '
        '_oCol_247
        '
        Me._oCol_247.AcceptsReturn = True
        Me._oCol_247.AutoSize = False
        Me._oCol_247.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_247.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_247.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_247.Enabled = False
        Me._oCol_247.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_247.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_247.Location = New System.Drawing.Point(72, 232)
        Me._oCol_247.MaxLength = 0
        Me._oCol_247.Name = "_oCol_247"
        Me._oCol_247.ReadOnly = True
        Me._oCol_247.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_247.Size = New System.Drawing.Size(17, 25)
        Me._oCol_247.TabIndex = 268
        Me._oCol_247.Text = ""
        '
        '_oCol_246
        '
        Me._oCol_246.AcceptsReturn = True
        Me._oCol_246.AutoSize = False
        Me._oCol_246.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_246.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_246.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_246.Enabled = False
        Me._oCol_246.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_246.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_246.Location = New System.Drawing.Point(56, 232)
        Me._oCol_246.MaxLength = 0
        Me._oCol_246.Name = "_oCol_246"
        Me._oCol_246.ReadOnly = True
        Me._oCol_246.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_246.Size = New System.Drawing.Size(17, 25)
        Me._oCol_246.TabIndex = 267
        Me._oCol_246.Text = ""
        '
        '_oCol_245
        '
        Me._oCol_245.AcceptsReturn = True
        Me._oCol_245.AutoSize = False
        Me._oCol_245.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_245.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_245.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_245.Enabled = False
        Me._oCol_245.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_245.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_245.Location = New System.Drawing.Point(40, 232)
        Me._oCol_245.MaxLength = 0
        Me._oCol_245.Name = "_oCol_245"
        Me._oCol_245.ReadOnly = True
        Me._oCol_245.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_245.Size = New System.Drawing.Size(17, 25)
        Me._oCol_245.TabIndex = 266
        Me._oCol_245.Text = ""
        '
        '_oCol_244
        '
        Me._oCol_244.AcceptsReturn = True
        Me._oCol_244.AutoSize = False
        Me._oCol_244.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_244.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_244.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_244.Enabled = False
        Me._oCol_244.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_244.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_244.Location = New System.Drawing.Point(24, 232)
        Me._oCol_244.MaxLength = 0
        Me._oCol_244.Name = "_oCol_244"
        Me._oCol_244.ReadOnly = True
        Me._oCol_244.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_244.Size = New System.Drawing.Size(17, 25)
        Me._oCol_244.TabIndex = 265
        Me._oCol_244.Text = ""
        '
        '_oCol_243
        '
        Me._oCol_243.AcceptsReturn = True
        Me._oCol_243.AutoSize = False
        Me._oCol_243.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_243.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_243.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_243.Enabled = False
        Me._oCol_243.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_243.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_243.Location = New System.Drawing.Point(8, 232)
        Me._oCol_243.MaxLength = 0
        Me._oCol_243.Name = "_oCol_243"
        Me._oCol_243.ReadOnly = True
        Me._oCol_243.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_243.Size = New System.Drawing.Size(17, 25)
        Me._oCol_243.TabIndex = 264
        Me._oCol_243.Text = ""
        '
        '_oCol_242
        '
        Me._oCol_242.AcceptsReturn = True
        Me._oCol_242.AutoSize = False
        Me._oCol_242.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_242.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_242.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_242.Enabled = False
        Me._oCol_242.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_242.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_242.Location = New System.Drawing.Point(424, 208)
        Me._oCol_242.MaxLength = 0
        Me._oCol_242.Name = "_oCol_242"
        Me._oCol_242.ReadOnly = True
        Me._oCol_242.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_242.Size = New System.Drawing.Size(17, 25)
        Me._oCol_242.TabIndex = 263
        Me._oCol_242.Text = ""
        '
        '_oCol_241
        '
        Me._oCol_241.AcceptsReturn = True
        Me._oCol_241.AutoSize = False
        Me._oCol_241.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_241.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_241.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_241.Enabled = False
        Me._oCol_241.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_241.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_241.Location = New System.Drawing.Point(408, 208)
        Me._oCol_241.MaxLength = 0
        Me._oCol_241.Name = "_oCol_241"
        Me._oCol_241.ReadOnly = True
        Me._oCol_241.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_241.Size = New System.Drawing.Size(17, 25)
        Me._oCol_241.TabIndex = 262
        Me._oCol_241.Text = ""
        '
        '_oCol_240
        '
        Me._oCol_240.AcceptsReturn = True
        Me._oCol_240.AutoSize = False
        Me._oCol_240.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_240.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_240.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_240.Enabled = False
        Me._oCol_240.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_240.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_240.Location = New System.Drawing.Point(392, 208)
        Me._oCol_240.MaxLength = 0
        Me._oCol_240.Name = "_oCol_240"
        Me._oCol_240.ReadOnly = True
        Me._oCol_240.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_240.Size = New System.Drawing.Size(17, 25)
        Me._oCol_240.TabIndex = 261
        Me._oCol_240.Text = ""
        '
        '_oCol_239
        '
        Me._oCol_239.AcceptsReturn = True
        Me._oCol_239.AutoSize = False
        Me._oCol_239.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_239.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_239.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_239.Enabled = False
        Me._oCol_239.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_239.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_239.Location = New System.Drawing.Point(376, 208)
        Me._oCol_239.MaxLength = 0
        Me._oCol_239.Name = "_oCol_239"
        Me._oCol_239.ReadOnly = True
        Me._oCol_239.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_239.Size = New System.Drawing.Size(17, 25)
        Me._oCol_239.TabIndex = 260
        Me._oCol_239.Text = ""
        '
        '_oCol_238
        '
        Me._oCol_238.AcceptsReturn = True
        Me._oCol_238.AutoSize = False
        Me._oCol_238.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_238.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_238.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_238.Enabled = False
        Me._oCol_238.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_238.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_238.Location = New System.Drawing.Point(360, 208)
        Me._oCol_238.MaxLength = 0
        Me._oCol_238.Name = "_oCol_238"
        Me._oCol_238.ReadOnly = True
        Me._oCol_238.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_238.Size = New System.Drawing.Size(17, 25)
        Me._oCol_238.TabIndex = 259
        Me._oCol_238.Text = ""
        '
        '_oCol_237
        '
        Me._oCol_237.AcceptsReturn = True
        Me._oCol_237.AutoSize = False
        Me._oCol_237.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_237.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_237.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_237.Enabled = False
        Me._oCol_237.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_237.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_237.Location = New System.Drawing.Point(344, 208)
        Me._oCol_237.MaxLength = 0
        Me._oCol_237.Name = "_oCol_237"
        Me._oCol_237.ReadOnly = True
        Me._oCol_237.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_237.Size = New System.Drawing.Size(17, 25)
        Me._oCol_237.TabIndex = 258
        Me._oCol_237.Text = ""
        '
        '_oCol_236
        '
        Me._oCol_236.AcceptsReturn = True
        Me._oCol_236.AutoSize = False
        Me._oCol_236.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_236.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_236.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_236.Enabled = False
        Me._oCol_236.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_236.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_236.Location = New System.Drawing.Point(328, 208)
        Me._oCol_236.MaxLength = 0
        Me._oCol_236.Name = "_oCol_236"
        Me._oCol_236.ReadOnly = True
        Me._oCol_236.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_236.Size = New System.Drawing.Size(17, 25)
        Me._oCol_236.TabIndex = 257
        Me._oCol_236.Text = ""
        '
        '_oCol_235
        '
        Me._oCol_235.AcceptsReturn = True
        Me._oCol_235.AutoSize = False
        Me._oCol_235.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_235.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_235.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_235.Enabled = False
        Me._oCol_235.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_235.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_235.Location = New System.Drawing.Point(312, 208)
        Me._oCol_235.MaxLength = 0
        Me._oCol_235.Name = "_oCol_235"
        Me._oCol_235.ReadOnly = True
        Me._oCol_235.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_235.Size = New System.Drawing.Size(17, 25)
        Me._oCol_235.TabIndex = 256
        Me._oCol_235.Text = ""
        '
        '_oCol_234
        '
        Me._oCol_234.AcceptsReturn = True
        Me._oCol_234.AutoSize = False
        Me._oCol_234.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_234.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_234.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_234.Enabled = False
        Me._oCol_234.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_234.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_234.Location = New System.Drawing.Point(296, 208)
        Me._oCol_234.MaxLength = 0
        Me._oCol_234.Name = "_oCol_234"
        Me._oCol_234.ReadOnly = True
        Me._oCol_234.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_234.Size = New System.Drawing.Size(17, 25)
        Me._oCol_234.TabIndex = 255
        Me._oCol_234.Text = ""
        '
        '_oCol_233
        '
        Me._oCol_233.AcceptsReturn = True
        Me._oCol_233.AutoSize = False
        Me._oCol_233.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_233.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_233.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_233.Enabled = False
        Me._oCol_233.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_233.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_233.Location = New System.Drawing.Point(280, 208)
        Me._oCol_233.MaxLength = 0
        Me._oCol_233.Name = "_oCol_233"
        Me._oCol_233.ReadOnly = True
        Me._oCol_233.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_233.Size = New System.Drawing.Size(17, 25)
        Me._oCol_233.TabIndex = 254
        Me._oCol_233.Text = ""
        '
        '_oCol_232
        '
        Me._oCol_232.AcceptsReturn = True
        Me._oCol_232.AutoSize = False
        Me._oCol_232.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_232.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_232.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_232.Enabled = False
        Me._oCol_232.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_232.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_232.Location = New System.Drawing.Point(264, 208)
        Me._oCol_232.MaxLength = 0
        Me._oCol_232.Name = "_oCol_232"
        Me._oCol_232.ReadOnly = True
        Me._oCol_232.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_232.Size = New System.Drawing.Size(17, 25)
        Me._oCol_232.TabIndex = 253
        Me._oCol_232.Text = ""
        '
        '_oCol_231
        '
        Me._oCol_231.AcceptsReturn = True
        Me._oCol_231.AutoSize = False
        Me._oCol_231.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_231.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_231.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_231.Enabled = False
        Me._oCol_231.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_231.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_231.Location = New System.Drawing.Point(248, 208)
        Me._oCol_231.MaxLength = 0
        Me._oCol_231.Name = "_oCol_231"
        Me._oCol_231.ReadOnly = True
        Me._oCol_231.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_231.Size = New System.Drawing.Size(17, 25)
        Me._oCol_231.TabIndex = 252
        Me._oCol_231.Text = ""
        '
        '_oCol_230
        '
        Me._oCol_230.AcceptsReturn = True
        Me._oCol_230.AutoSize = False
        Me._oCol_230.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_230.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_230.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_230.Enabled = False
        Me._oCol_230.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_230.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_230.Location = New System.Drawing.Point(232, 208)
        Me._oCol_230.MaxLength = 0
        Me._oCol_230.Name = "_oCol_230"
        Me._oCol_230.ReadOnly = True
        Me._oCol_230.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_230.Size = New System.Drawing.Size(17, 25)
        Me._oCol_230.TabIndex = 251
        Me._oCol_230.Text = ""
        '
        '_oCol_229
        '
        Me._oCol_229.AcceptsReturn = True
        Me._oCol_229.AutoSize = False
        Me._oCol_229.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_229.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_229.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_229.Enabled = False
        Me._oCol_229.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_229.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_229.Location = New System.Drawing.Point(216, 208)
        Me._oCol_229.MaxLength = 0
        Me._oCol_229.Name = "_oCol_229"
        Me._oCol_229.ReadOnly = True
        Me._oCol_229.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_229.Size = New System.Drawing.Size(17, 25)
        Me._oCol_229.TabIndex = 250
        Me._oCol_229.Text = ""
        '
        '_oCol_228
        '
        Me._oCol_228.AcceptsReturn = True
        Me._oCol_228.AutoSize = False
        Me._oCol_228.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_228.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_228.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_228.Enabled = False
        Me._oCol_228.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_228.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_228.Location = New System.Drawing.Point(200, 208)
        Me._oCol_228.MaxLength = 0
        Me._oCol_228.Name = "_oCol_228"
        Me._oCol_228.ReadOnly = True
        Me._oCol_228.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_228.Size = New System.Drawing.Size(17, 25)
        Me._oCol_228.TabIndex = 249
        Me._oCol_228.Text = ""
        '
        '_oCol_227
        '
        Me._oCol_227.AcceptsReturn = True
        Me._oCol_227.AutoSize = False
        Me._oCol_227.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_227.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_227.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_227.Enabled = False
        Me._oCol_227.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_227.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_227.Location = New System.Drawing.Point(184, 208)
        Me._oCol_227.MaxLength = 0
        Me._oCol_227.Name = "_oCol_227"
        Me._oCol_227.ReadOnly = True
        Me._oCol_227.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_227.Size = New System.Drawing.Size(17, 25)
        Me._oCol_227.TabIndex = 248
        Me._oCol_227.Text = ""
        '
        '_oCol_226
        '
        Me._oCol_226.AcceptsReturn = True
        Me._oCol_226.AutoSize = False
        Me._oCol_226.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_226.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_226.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_226.Enabled = False
        Me._oCol_226.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_226.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_226.Location = New System.Drawing.Point(168, 208)
        Me._oCol_226.MaxLength = 0
        Me._oCol_226.Name = "_oCol_226"
        Me._oCol_226.ReadOnly = True
        Me._oCol_226.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_226.Size = New System.Drawing.Size(17, 25)
        Me._oCol_226.TabIndex = 247
        Me._oCol_226.Text = ""
        '
        '_oCol_225
        '
        Me._oCol_225.AcceptsReturn = True
        Me._oCol_225.AutoSize = False
        Me._oCol_225.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_225.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_225.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_225.Enabled = False
        Me._oCol_225.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_225.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_225.Location = New System.Drawing.Point(152, 208)
        Me._oCol_225.MaxLength = 0
        Me._oCol_225.Name = "_oCol_225"
        Me._oCol_225.ReadOnly = True
        Me._oCol_225.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_225.Size = New System.Drawing.Size(17, 25)
        Me._oCol_225.TabIndex = 246
        Me._oCol_225.Text = ""
        '
        '_oCol_224
        '
        Me._oCol_224.AcceptsReturn = True
        Me._oCol_224.AutoSize = False
        Me._oCol_224.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_224.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_224.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_224.Enabled = False
        Me._oCol_224.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_224.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_224.Location = New System.Drawing.Point(136, 208)
        Me._oCol_224.MaxLength = 0
        Me._oCol_224.Name = "_oCol_224"
        Me._oCol_224.ReadOnly = True
        Me._oCol_224.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_224.Size = New System.Drawing.Size(17, 25)
        Me._oCol_224.TabIndex = 245
        Me._oCol_224.Text = ""
        '
        '_oCol_223
        '
        Me._oCol_223.AcceptsReturn = True
        Me._oCol_223.AutoSize = False
        Me._oCol_223.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_223.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_223.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_223.Enabled = False
        Me._oCol_223.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_223.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_223.Location = New System.Drawing.Point(120, 208)
        Me._oCol_223.MaxLength = 0
        Me._oCol_223.Name = "_oCol_223"
        Me._oCol_223.ReadOnly = True
        Me._oCol_223.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_223.Size = New System.Drawing.Size(17, 25)
        Me._oCol_223.TabIndex = 244
        Me._oCol_223.Text = ""
        '
        '_oCol_222
        '
        Me._oCol_222.AcceptsReturn = True
        Me._oCol_222.AutoSize = False
        Me._oCol_222.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_222.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_222.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_222.Enabled = False
        Me._oCol_222.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_222.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_222.Location = New System.Drawing.Point(104, 208)
        Me._oCol_222.MaxLength = 0
        Me._oCol_222.Name = "_oCol_222"
        Me._oCol_222.ReadOnly = True
        Me._oCol_222.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_222.Size = New System.Drawing.Size(17, 25)
        Me._oCol_222.TabIndex = 243
        Me._oCol_222.Text = ""
        '
        '_oCol_221
        '
        Me._oCol_221.AcceptsReturn = True
        Me._oCol_221.AutoSize = False
        Me._oCol_221.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_221.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_221.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_221.Enabled = False
        Me._oCol_221.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_221.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_221.Location = New System.Drawing.Point(88, 208)
        Me._oCol_221.MaxLength = 0
        Me._oCol_221.Name = "_oCol_221"
        Me._oCol_221.ReadOnly = True
        Me._oCol_221.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_221.Size = New System.Drawing.Size(17, 25)
        Me._oCol_221.TabIndex = 242
        Me._oCol_221.Text = ""
        '
        '_oCol_220
        '
        Me._oCol_220.AcceptsReturn = True
        Me._oCol_220.AutoSize = False
        Me._oCol_220.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_220.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_220.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_220.Enabled = False
        Me._oCol_220.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_220.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_220.Location = New System.Drawing.Point(72, 208)
        Me._oCol_220.MaxLength = 0
        Me._oCol_220.Name = "_oCol_220"
        Me._oCol_220.ReadOnly = True
        Me._oCol_220.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_220.Size = New System.Drawing.Size(17, 25)
        Me._oCol_220.TabIndex = 241
        Me._oCol_220.Text = ""
        '
        '_oCol_219
        '
        Me._oCol_219.AcceptsReturn = True
        Me._oCol_219.AutoSize = False
        Me._oCol_219.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_219.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_219.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_219.Enabled = False
        Me._oCol_219.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_219.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_219.Location = New System.Drawing.Point(56, 208)
        Me._oCol_219.MaxLength = 0
        Me._oCol_219.Name = "_oCol_219"
        Me._oCol_219.ReadOnly = True
        Me._oCol_219.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_219.Size = New System.Drawing.Size(17, 25)
        Me._oCol_219.TabIndex = 240
        Me._oCol_219.Text = ""
        '
        '_oCol_218
        '
        Me._oCol_218.AcceptsReturn = True
        Me._oCol_218.AutoSize = False
        Me._oCol_218.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_218.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_218.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_218.Enabled = False
        Me._oCol_218.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_218.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_218.Location = New System.Drawing.Point(40, 208)
        Me._oCol_218.MaxLength = 0
        Me._oCol_218.Name = "_oCol_218"
        Me._oCol_218.ReadOnly = True
        Me._oCol_218.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_218.Size = New System.Drawing.Size(17, 25)
        Me._oCol_218.TabIndex = 239
        Me._oCol_218.Text = ""
        '
        '_oCol_217
        '
        Me._oCol_217.AcceptsReturn = True
        Me._oCol_217.AutoSize = False
        Me._oCol_217.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_217.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_217.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_217.Enabled = False
        Me._oCol_217.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_217.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_217.Location = New System.Drawing.Point(24, 208)
        Me._oCol_217.MaxLength = 0
        Me._oCol_217.Name = "_oCol_217"
        Me._oCol_217.ReadOnly = True
        Me._oCol_217.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_217.Size = New System.Drawing.Size(17, 25)
        Me._oCol_217.TabIndex = 238
        Me._oCol_217.Text = ""
        '
        '_oCol_216
        '
        Me._oCol_216.AcceptsReturn = True
        Me._oCol_216.AutoSize = False
        Me._oCol_216.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_216.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_216.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_216.Enabled = False
        Me._oCol_216.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_216.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_216.Location = New System.Drawing.Point(8, 208)
        Me._oCol_216.MaxLength = 0
        Me._oCol_216.Name = "_oCol_216"
        Me._oCol_216.ReadOnly = True
        Me._oCol_216.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_216.Size = New System.Drawing.Size(17, 25)
        Me._oCol_216.TabIndex = 237
        Me._oCol_216.Text = ""
        '
        '_oCol_215
        '
        Me._oCol_215.AcceptsReturn = True
        Me._oCol_215.AutoSize = False
        Me._oCol_215.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_215.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_215.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_215.Enabled = False
        Me._oCol_215.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_215.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_215.Location = New System.Drawing.Point(424, 184)
        Me._oCol_215.MaxLength = 0
        Me._oCol_215.Name = "_oCol_215"
        Me._oCol_215.ReadOnly = True
        Me._oCol_215.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_215.Size = New System.Drawing.Size(17, 25)
        Me._oCol_215.TabIndex = 236
        Me._oCol_215.Text = ""
        '
        '_oCol_214
        '
        Me._oCol_214.AcceptsReturn = True
        Me._oCol_214.AutoSize = False
        Me._oCol_214.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_214.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_214.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_214.Enabled = False
        Me._oCol_214.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_214.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_214.Location = New System.Drawing.Point(408, 184)
        Me._oCol_214.MaxLength = 0
        Me._oCol_214.Name = "_oCol_214"
        Me._oCol_214.ReadOnly = True
        Me._oCol_214.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_214.Size = New System.Drawing.Size(17, 25)
        Me._oCol_214.TabIndex = 235
        Me._oCol_214.Text = ""
        '
        '_oCol_213
        '
        Me._oCol_213.AcceptsReturn = True
        Me._oCol_213.AutoSize = False
        Me._oCol_213.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_213.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_213.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_213.Enabled = False
        Me._oCol_213.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_213.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_213.Location = New System.Drawing.Point(392, 184)
        Me._oCol_213.MaxLength = 0
        Me._oCol_213.Name = "_oCol_213"
        Me._oCol_213.ReadOnly = True
        Me._oCol_213.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_213.Size = New System.Drawing.Size(17, 25)
        Me._oCol_213.TabIndex = 234
        Me._oCol_213.Text = ""
        '
        '_oCol_212
        '
        Me._oCol_212.AcceptsReturn = True
        Me._oCol_212.AutoSize = False
        Me._oCol_212.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_212.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_212.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_212.Enabled = False
        Me._oCol_212.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_212.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_212.Location = New System.Drawing.Point(376, 184)
        Me._oCol_212.MaxLength = 0
        Me._oCol_212.Name = "_oCol_212"
        Me._oCol_212.ReadOnly = True
        Me._oCol_212.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_212.Size = New System.Drawing.Size(17, 25)
        Me._oCol_212.TabIndex = 233
        Me._oCol_212.Text = ""
        '
        '_oCol_211
        '
        Me._oCol_211.AcceptsReturn = True
        Me._oCol_211.AutoSize = False
        Me._oCol_211.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_211.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_211.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_211.Enabled = False
        Me._oCol_211.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_211.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_211.Location = New System.Drawing.Point(360, 184)
        Me._oCol_211.MaxLength = 0
        Me._oCol_211.Name = "_oCol_211"
        Me._oCol_211.ReadOnly = True
        Me._oCol_211.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_211.Size = New System.Drawing.Size(17, 25)
        Me._oCol_211.TabIndex = 232
        Me._oCol_211.Text = ""
        '
        '_oCol_210
        '
        Me._oCol_210.AcceptsReturn = True
        Me._oCol_210.AutoSize = False
        Me._oCol_210.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_210.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_210.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_210.Enabled = False
        Me._oCol_210.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_210.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_210.Location = New System.Drawing.Point(344, 184)
        Me._oCol_210.MaxLength = 0
        Me._oCol_210.Name = "_oCol_210"
        Me._oCol_210.ReadOnly = True
        Me._oCol_210.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_210.Size = New System.Drawing.Size(17, 25)
        Me._oCol_210.TabIndex = 231
        Me._oCol_210.Text = ""
        '
        '_oCol_209
        '
        Me._oCol_209.AcceptsReturn = True
        Me._oCol_209.AutoSize = False
        Me._oCol_209.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_209.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_209.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_209.Enabled = False
        Me._oCol_209.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_209.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_209.Location = New System.Drawing.Point(328, 184)
        Me._oCol_209.MaxLength = 0
        Me._oCol_209.Name = "_oCol_209"
        Me._oCol_209.ReadOnly = True
        Me._oCol_209.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_209.Size = New System.Drawing.Size(17, 25)
        Me._oCol_209.TabIndex = 230
        Me._oCol_209.Text = ""
        '
        '_oCol_208
        '
        Me._oCol_208.AcceptsReturn = True
        Me._oCol_208.AutoSize = False
        Me._oCol_208.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_208.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_208.Enabled = False
        Me._oCol_208.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_208.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_208.Location = New System.Drawing.Point(312, 184)
        Me._oCol_208.MaxLength = 0
        Me._oCol_208.Name = "_oCol_208"
        Me._oCol_208.ReadOnly = True
        Me._oCol_208.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_208.Size = New System.Drawing.Size(17, 25)
        Me._oCol_208.TabIndex = 229
        Me._oCol_208.Text = ""
        '
        '_oCol_207
        '
        Me._oCol_207.AcceptsReturn = True
        Me._oCol_207.AutoSize = False
        Me._oCol_207.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_207.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_207.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_207.Enabled = False
        Me._oCol_207.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_207.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_207.Location = New System.Drawing.Point(296, 184)
        Me._oCol_207.MaxLength = 0
        Me._oCol_207.Name = "_oCol_207"
        Me._oCol_207.ReadOnly = True
        Me._oCol_207.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_207.Size = New System.Drawing.Size(17, 25)
        Me._oCol_207.TabIndex = 228
        Me._oCol_207.Text = ""
        '
        '_oCol_206
        '
        Me._oCol_206.AcceptsReturn = True
        Me._oCol_206.AutoSize = False
        Me._oCol_206.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_206.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_206.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_206.Enabled = False
        Me._oCol_206.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_206.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_206.Location = New System.Drawing.Point(280, 184)
        Me._oCol_206.MaxLength = 0
        Me._oCol_206.Name = "_oCol_206"
        Me._oCol_206.ReadOnly = True
        Me._oCol_206.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_206.Size = New System.Drawing.Size(17, 25)
        Me._oCol_206.TabIndex = 227
        Me._oCol_206.Text = ""
        '
        '_oCol_205
        '
        Me._oCol_205.AcceptsReturn = True
        Me._oCol_205.AutoSize = False
        Me._oCol_205.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_205.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_205.Enabled = False
        Me._oCol_205.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_205.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_205.Location = New System.Drawing.Point(264, 184)
        Me._oCol_205.MaxLength = 0
        Me._oCol_205.Name = "_oCol_205"
        Me._oCol_205.ReadOnly = True
        Me._oCol_205.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_205.Size = New System.Drawing.Size(17, 25)
        Me._oCol_205.TabIndex = 226
        Me._oCol_205.Text = ""
        '
        '_oCol_204
        '
        Me._oCol_204.AcceptsReturn = True
        Me._oCol_204.AutoSize = False
        Me._oCol_204.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_204.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_204.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_204.Enabled = False
        Me._oCol_204.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_204.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_204.Location = New System.Drawing.Point(248, 184)
        Me._oCol_204.MaxLength = 0
        Me._oCol_204.Name = "_oCol_204"
        Me._oCol_204.ReadOnly = True
        Me._oCol_204.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_204.Size = New System.Drawing.Size(17, 25)
        Me._oCol_204.TabIndex = 225
        Me._oCol_204.Text = ""
        '
        '_oCol_203
        '
        Me._oCol_203.AcceptsReturn = True
        Me._oCol_203.AutoSize = False
        Me._oCol_203.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_203.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_203.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_203.Enabled = False
        Me._oCol_203.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_203.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_203.Location = New System.Drawing.Point(232, 184)
        Me._oCol_203.MaxLength = 0
        Me._oCol_203.Name = "_oCol_203"
        Me._oCol_203.ReadOnly = True
        Me._oCol_203.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_203.Size = New System.Drawing.Size(17, 25)
        Me._oCol_203.TabIndex = 224
        Me._oCol_203.Text = ""
        '
        '_oCol_202
        '
        Me._oCol_202.AcceptsReturn = True
        Me._oCol_202.AutoSize = False
        Me._oCol_202.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_202.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_202.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_202.Enabled = False
        Me._oCol_202.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_202.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_202.Location = New System.Drawing.Point(216, 184)
        Me._oCol_202.MaxLength = 0
        Me._oCol_202.Name = "_oCol_202"
        Me._oCol_202.ReadOnly = True
        Me._oCol_202.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_202.Size = New System.Drawing.Size(17, 25)
        Me._oCol_202.TabIndex = 223
        Me._oCol_202.Text = ""
        '
        '_oCol_201
        '
        Me._oCol_201.AcceptsReturn = True
        Me._oCol_201.AutoSize = False
        Me._oCol_201.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_201.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_201.Enabled = False
        Me._oCol_201.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_201.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_201.Location = New System.Drawing.Point(200, 184)
        Me._oCol_201.MaxLength = 0
        Me._oCol_201.Name = "_oCol_201"
        Me._oCol_201.ReadOnly = True
        Me._oCol_201.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_201.Size = New System.Drawing.Size(17, 25)
        Me._oCol_201.TabIndex = 222
        Me._oCol_201.Text = ""
        '
        '_oCol_200
        '
        Me._oCol_200.AcceptsReturn = True
        Me._oCol_200.AutoSize = False
        Me._oCol_200.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_200.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_200.Enabled = False
        Me._oCol_200.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_200.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_200.Location = New System.Drawing.Point(184, 184)
        Me._oCol_200.MaxLength = 0
        Me._oCol_200.Name = "_oCol_200"
        Me._oCol_200.ReadOnly = True
        Me._oCol_200.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_200.Size = New System.Drawing.Size(17, 25)
        Me._oCol_200.TabIndex = 221
        Me._oCol_200.Text = ""
        '
        '_oCol_199
        '
        Me._oCol_199.AcceptsReturn = True
        Me._oCol_199.AutoSize = False
        Me._oCol_199.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_199.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_199.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_199.Enabled = False
        Me._oCol_199.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_199.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_199.Location = New System.Drawing.Point(168, 184)
        Me._oCol_199.MaxLength = 0
        Me._oCol_199.Name = "_oCol_199"
        Me._oCol_199.ReadOnly = True
        Me._oCol_199.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_199.Size = New System.Drawing.Size(17, 25)
        Me._oCol_199.TabIndex = 220
        Me._oCol_199.Text = ""
        '
        '_oCol_198
        '
        Me._oCol_198.AcceptsReturn = True
        Me._oCol_198.AutoSize = False
        Me._oCol_198.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_198.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_198.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_198.Enabled = False
        Me._oCol_198.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_198.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_198.Location = New System.Drawing.Point(152, 184)
        Me._oCol_198.MaxLength = 0
        Me._oCol_198.Name = "_oCol_198"
        Me._oCol_198.ReadOnly = True
        Me._oCol_198.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_198.Size = New System.Drawing.Size(17, 25)
        Me._oCol_198.TabIndex = 219
        Me._oCol_198.Text = ""
        '
        '_oCol_197
        '
        Me._oCol_197.AcceptsReturn = True
        Me._oCol_197.AutoSize = False
        Me._oCol_197.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_197.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_197.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_197.Enabled = False
        Me._oCol_197.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_197.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_197.Location = New System.Drawing.Point(136, 184)
        Me._oCol_197.MaxLength = 0
        Me._oCol_197.Name = "_oCol_197"
        Me._oCol_197.ReadOnly = True
        Me._oCol_197.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_197.Size = New System.Drawing.Size(17, 25)
        Me._oCol_197.TabIndex = 218
        Me._oCol_197.Text = ""
        '
        '_oCol_196
        '
        Me._oCol_196.AcceptsReturn = True
        Me._oCol_196.AutoSize = False
        Me._oCol_196.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_196.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_196.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_196.Enabled = False
        Me._oCol_196.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_196.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_196.Location = New System.Drawing.Point(120, 184)
        Me._oCol_196.MaxLength = 0
        Me._oCol_196.Name = "_oCol_196"
        Me._oCol_196.ReadOnly = True
        Me._oCol_196.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_196.Size = New System.Drawing.Size(17, 25)
        Me._oCol_196.TabIndex = 217
        Me._oCol_196.Text = ""
        '
        '_oCol_195
        '
        Me._oCol_195.AcceptsReturn = True
        Me._oCol_195.AutoSize = False
        Me._oCol_195.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_195.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_195.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_195.Enabled = False
        Me._oCol_195.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_195.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_195.Location = New System.Drawing.Point(104, 184)
        Me._oCol_195.MaxLength = 0
        Me._oCol_195.Name = "_oCol_195"
        Me._oCol_195.ReadOnly = True
        Me._oCol_195.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_195.Size = New System.Drawing.Size(17, 25)
        Me._oCol_195.TabIndex = 216
        Me._oCol_195.Text = ""
        '
        '_oCol_194
        '
        Me._oCol_194.AcceptsReturn = True
        Me._oCol_194.AutoSize = False
        Me._oCol_194.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_194.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_194.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_194.Enabled = False
        Me._oCol_194.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_194.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_194.Location = New System.Drawing.Point(88, 184)
        Me._oCol_194.MaxLength = 0
        Me._oCol_194.Name = "_oCol_194"
        Me._oCol_194.ReadOnly = True
        Me._oCol_194.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_194.Size = New System.Drawing.Size(17, 25)
        Me._oCol_194.TabIndex = 215
        Me._oCol_194.Text = ""
        '
        '_oCol_193
        '
        Me._oCol_193.AcceptsReturn = True
        Me._oCol_193.AutoSize = False
        Me._oCol_193.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_193.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_193.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_193.Enabled = False
        Me._oCol_193.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_193.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_193.Location = New System.Drawing.Point(72, 184)
        Me._oCol_193.MaxLength = 0
        Me._oCol_193.Name = "_oCol_193"
        Me._oCol_193.ReadOnly = True
        Me._oCol_193.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_193.Size = New System.Drawing.Size(17, 25)
        Me._oCol_193.TabIndex = 214
        Me._oCol_193.Text = ""
        '
        '_oCol_192
        '
        Me._oCol_192.AcceptsReturn = True
        Me._oCol_192.AutoSize = False
        Me._oCol_192.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_192.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_192.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_192.Enabled = False
        Me._oCol_192.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_192.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_192.Location = New System.Drawing.Point(56, 184)
        Me._oCol_192.MaxLength = 0
        Me._oCol_192.Name = "_oCol_192"
        Me._oCol_192.ReadOnly = True
        Me._oCol_192.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_192.Size = New System.Drawing.Size(17, 25)
        Me._oCol_192.TabIndex = 213
        Me._oCol_192.Text = ""
        '
        '_oCol_191
        '
        Me._oCol_191.AcceptsReturn = True
        Me._oCol_191.AutoSize = False
        Me._oCol_191.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_191.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_191.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_191.Enabled = False
        Me._oCol_191.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_191.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_191.Location = New System.Drawing.Point(40, 184)
        Me._oCol_191.MaxLength = 0
        Me._oCol_191.Name = "_oCol_191"
        Me._oCol_191.ReadOnly = True
        Me._oCol_191.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_191.Size = New System.Drawing.Size(17, 25)
        Me._oCol_191.TabIndex = 212
        Me._oCol_191.Text = ""
        '
        '_oCol_190
        '
        Me._oCol_190.AcceptsReturn = True
        Me._oCol_190.AutoSize = False
        Me._oCol_190.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_190.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_190.Enabled = False
        Me._oCol_190.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_190.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_190.Location = New System.Drawing.Point(24, 184)
        Me._oCol_190.MaxLength = 0
        Me._oCol_190.Name = "_oCol_190"
        Me._oCol_190.ReadOnly = True
        Me._oCol_190.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_190.Size = New System.Drawing.Size(17, 25)
        Me._oCol_190.TabIndex = 211
        Me._oCol_190.Text = ""
        '
        '_oCol_189
        '
        Me._oCol_189.AcceptsReturn = True
        Me._oCol_189.AutoSize = False
        Me._oCol_189.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_189.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_189.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_189.Enabled = False
        Me._oCol_189.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_189.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_189.Location = New System.Drawing.Point(8, 184)
        Me._oCol_189.MaxLength = 0
        Me._oCol_189.Name = "_oCol_189"
        Me._oCol_189.ReadOnly = True
        Me._oCol_189.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_189.Size = New System.Drawing.Size(17, 25)
        Me._oCol_189.TabIndex = 210
        Me._oCol_189.Text = ""
        '
        '_oCol_188
        '
        Me._oCol_188.AcceptsReturn = True
        Me._oCol_188.AutoSize = False
        Me._oCol_188.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_188.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_188.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_188.Enabled = False
        Me._oCol_188.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_188.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_188.Location = New System.Drawing.Point(424, 160)
        Me._oCol_188.MaxLength = 0
        Me._oCol_188.Name = "_oCol_188"
        Me._oCol_188.ReadOnly = True
        Me._oCol_188.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_188.Size = New System.Drawing.Size(17, 25)
        Me._oCol_188.TabIndex = 209
        Me._oCol_188.Text = ""
        '
        '_oCol_187
        '
        Me._oCol_187.AcceptsReturn = True
        Me._oCol_187.AutoSize = False
        Me._oCol_187.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_187.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_187.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_187.Enabled = False
        Me._oCol_187.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_187.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_187.Location = New System.Drawing.Point(408, 160)
        Me._oCol_187.MaxLength = 0
        Me._oCol_187.Name = "_oCol_187"
        Me._oCol_187.ReadOnly = True
        Me._oCol_187.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_187.Size = New System.Drawing.Size(17, 25)
        Me._oCol_187.TabIndex = 208
        Me._oCol_187.Text = ""
        '
        '_oCol_186
        '
        Me._oCol_186.AcceptsReturn = True
        Me._oCol_186.AutoSize = False
        Me._oCol_186.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_186.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_186.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_186.Enabled = False
        Me._oCol_186.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_186.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_186.Location = New System.Drawing.Point(392, 160)
        Me._oCol_186.MaxLength = 0
        Me._oCol_186.Name = "_oCol_186"
        Me._oCol_186.ReadOnly = True
        Me._oCol_186.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_186.Size = New System.Drawing.Size(17, 25)
        Me._oCol_186.TabIndex = 207
        Me._oCol_186.Text = ""
        '
        '_oCol_185
        '
        Me._oCol_185.AcceptsReturn = True
        Me._oCol_185.AutoSize = False
        Me._oCol_185.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_185.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_185.Enabled = False
        Me._oCol_185.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_185.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_185.Location = New System.Drawing.Point(376, 160)
        Me._oCol_185.MaxLength = 0
        Me._oCol_185.Name = "_oCol_185"
        Me._oCol_185.ReadOnly = True
        Me._oCol_185.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_185.Size = New System.Drawing.Size(17, 25)
        Me._oCol_185.TabIndex = 206
        Me._oCol_185.Text = ""
        '
        '_oCol_184
        '
        Me._oCol_184.AcceptsReturn = True
        Me._oCol_184.AutoSize = False
        Me._oCol_184.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_184.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_184.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_184.Enabled = False
        Me._oCol_184.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_184.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_184.Location = New System.Drawing.Point(360, 160)
        Me._oCol_184.MaxLength = 0
        Me._oCol_184.Name = "_oCol_184"
        Me._oCol_184.ReadOnly = True
        Me._oCol_184.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_184.Size = New System.Drawing.Size(17, 25)
        Me._oCol_184.TabIndex = 205
        Me._oCol_184.Text = ""
        '
        '_oCol_183
        '
        Me._oCol_183.AcceptsReturn = True
        Me._oCol_183.AutoSize = False
        Me._oCol_183.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_183.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_183.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_183.Enabled = False
        Me._oCol_183.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_183.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_183.Location = New System.Drawing.Point(344, 160)
        Me._oCol_183.MaxLength = 0
        Me._oCol_183.Name = "_oCol_183"
        Me._oCol_183.ReadOnly = True
        Me._oCol_183.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_183.Size = New System.Drawing.Size(17, 25)
        Me._oCol_183.TabIndex = 204
        Me._oCol_183.Text = ""
        '
        '_oCol_182
        '
        Me._oCol_182.AcceptsReturn = True
        Me._oCol_182.AutoSize = False
        Me._oCol_182.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_182.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_182.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_182.Enabled = False
        Me._oCol_182.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_182.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_182.Location = New System.Drawing.Point(328, 160)
        Me._oCol_182.MaxLength = 0
        Me._oCol_182.Name = "_oCol_182"
        Me._oCol_182.ReadOnly = True
        Me._oCol_182.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_182.Size = New System.Drawing.Size(17, 25)
        Me._oCol_182.TabIndex = 203
        Me._oCol_182.Text = ""
        '
        '_oCol_181
        '
        Me._oCol_181.AcceptsReturn = True
        Me._oCol_181.AutoSize = False
        Me._oCol_181.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_181.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_181.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_181.Enabled = False
        Me._oCol_181.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_181.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_181.Location = New System.Drawing.Point(312, 160)
        Me._oCol_181.MaxLength = 0
        Me._oCol_181.Name = "_oCol_181"
        Me._oCol_181.ReadOnly = True
        Me._oCol_181.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_181.Size = New System.Drawing.Size(17, 25)
        Me._oCol_181.TabIndex = 202
        Me._oCol_181.Text = ""
        '
        '_oCol_180
        '
        Me._oCol_180.AcceptsReturn = True
        Me._oCol_180.AutoSize = False
        Me._oCol_180.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_180.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_180.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_180.Enabled = False
        Me._oCol_180.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_180.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_180.Location = New System.Drawing.Point(296, 160)
        Me._oCol_180.MaxLength = 0
        Me._oCol_180.Name = "_oCol_180"
        Me._oCol_180.ReadOnly = True
        Me._oCol_180.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_180.Size = New System.Drawing.Size(17, 25)
        Me._oCol_180.TabIndex = 201
        Me._oCol_180.Text = ""
        '
        '_oCol_179
        '
        Me._oCol_179.AcceptsReturn = True
        Me._oCol_179.AutoSize = False
        Me._oCol_179.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_179.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_179.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_179.Enabled = False
        Me._oCol_179.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_179.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_179.Location = New System.Drawing.Point(280, 160)
        Me._oCol_179.MaxLength = 0
        Me._oCol_179.Name = "_oCol_179"
        Me._oCol_179.ReadOnly = True
        Me._oCol_179.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_179.Size = New System.Drawing.Size(17, 25)
        Me._oCol_179.TabIndex = 200
        Me._oCol_179.Text = ""
        '
        '_oCol_178
        '
        Me._oCol_178.AcceptsReturn = True
        Me._oCol_178.AutoSize = False
        Me._oCol_178.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_178.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_178.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_178.Enabled = False
        Me._oCol_178.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_178.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_178.Location = New System.Drawing.Point(264, 160)
        Me._oCol_178.MaxLength = 0
        Me._oCol_178.Name = "_oCol_178"
        Me._oCol_178.ReadOnly = True
        Me._oCol_178.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_178.Size = New System.Drawing.Size(17, 25)
        Me._oCol_178.TabIndex = 199
        Me._oCol_178.Text = ""
        '
        '_oCol_177
        '
        Me._oCol_177.AcceptsReturn = True
        Me._oCol_177.AutoSize = False
        Me._oCol_177.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_177.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_177.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_177.Enabled = False
        Me._oCol_177.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_177.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_177.Location = New System.Drawing.Point(248, 160)
        Me._oCol_177.MaxLength = 0
        Me._oCol_177.Name = "_oCol_177"
        Me._oCol_177.ReadOnly = True
        Me._oCol_177.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_177.Size = New System.Drawing.Size(17, 25)
        Me._oCol_177.TabIndex = 198
        Me._oCol_177.Text = ""
        '
        '_oCol_176
        '
        Me._oCol_176.AcceptsReturn = True
        Me._oCol_176.AutoSize = False
        Me._oCol_176.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_176.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_176.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_176.Enabled = False
        Me._oCol_176.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_176.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_176.Location = New System.Drawing.Point(232, 160)
        Me._oCol_176.MaxLength = 0
        Me._oCol_176.Name = "_oCol_176"
        Me._oCol_176.ReadOnly = True
        Me._oCol_176.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_176.Size = New System.Drawing.Size(17, 25)
        Me._oCol_176.TabIndex = 197
        Me._oCol_176.Text = ""
        '
        '_oCol_175
        '
        Me._oCol_175.AcceptsReturn = True
        Me._oCol_175.AutoSize = False
        Me._oCol_175.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_175.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_175.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_175.Enabled = False
        Me._oCol_175.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_175.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_175.Location = New System.Drawing.Point(216, 160)
        Me._oCol_175.MaxLength = 0
        Me._oCol_175.Name = "_oCol_175"
        Me._oCol_175.ReadOnly = True
        Me._oCol_175.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_175.Size = New System.Drawing.Size(17, 25)
        Me._oCol_175.TabIndex = 196
        Me._oCol_175.Text = ""
        '
        '_oCol_174
        '
        Me._oCol_174.AcceptsReturn = True
        Me._oCol_174.AutoSize = False
        Me._oCol_174.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_174.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_174.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_174.Enabled = False
        Me._oCol_174.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_174.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_174.Location = New System.Drawing.Point(200, 160)
        Me._oCol_174.MaxLength = 0
        Me._oCol_174.Name = "_oCol_174"
        Me._oCol_174.ReadOnly = True
        Me._oCol_174.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_174.Size = New System.Drawing.Size(17, 25)
        Me._oCol_174.TabIndex = 195
        Me._oCol_174.Text = ""
        '
        '_oCol_173
        '
        Me._oCol_173.AcceptsReturn = True
        Me._oCol_173.AutoSize = False
        Me._oCol_173.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_173.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_173.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_173.Enabled = False
        Me._oCol_173.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_173.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_173.Location = New System.Drawing.Point(184, 160)
        Me._oCol_173.MaxLength = 0
        Me._oCol_173.Name = "_oCol_173"
        Me._oCol_173.ReadOnly = True
        Me._oCol_173.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_173.Size = New System.Drawing.Size(17, 25)
        Me._oCol_173.TabIndex = 194
        Me._oCol_173.Text = ""
        '
        '_oCol_172
        '
        Me._oCol_172.AcceptsReturn = True
        Me._oCol_172.AutoSize = False
        Me._oCol_172.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_172.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_172.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_172.Enabled = False
        Me._oCol_172.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_172.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_172.Location = New System.Drawing.Point(168, 160)
        Me._oCol_172.MaxLength = 0
        Me._oCol_172.Name = "_oCol_172"
        Me._oCol_172.ReadOnly = True
        Me._oCol_172.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_172.Size = New System.Drawing.Size(17, 25)
        Me._oCol_172.TabIndex = 193
        Me._oCol_172.Text = ""
        '
        '_oCol_171
        '
        Me._oCol_171.AcceptsReturn = True
        Me._oCol_171.AutoSize = False
        Me._oCol_171.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_171.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_171.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_171.Enabled = False
        Me._oCol_171.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_171.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_171.Location = New System.Drawing.Point(152, 160)
        Me._oCol_171.MaxLength = 0
        Me._oCol_171.Name = "_oCol_171"
        Me._oCol_171.ReadOnly = True
        Me._oCol_171.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_171.Size = New System.Drawing.Size(17, 25)
        Me._oCol_171.TabIndex = 192
        Me._oCol_171.Text = ""
        '
        '_oCol_170
        '
        Me._oCol_170.AcceptsReturn = True
        Me._oCol_170.AutoSize = False
        Me._oCol_170.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_170.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_170.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_170.Enabled = False
        Me._oCol_170.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_170.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_170.Location = New System.Drawing.Point(136, 160)
        Me._oCol_170.MaxLength = 0
        Me._oCol_170.Name = "_oCol_170"
        Me._oCol_170.ReadOnly = True
        Me._oCol_170.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_170.Size = New System.Drawing.Size(17, 25)
        Me._oCol_170.TabIndex = 191
        Me._oCol_170.Text = ""
        '
        '_oCol_169
        '
        Me._oCol_169.AcceptsReturn = True
        Me._oCol_169.AutoSize = False
        Me._oCol_169.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_169.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_169.Enabled = False
        Me._oCol_169.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_169.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_169.Location = New System.Drawing.Point(120, 160)
        Me._oCol_169.MaxLength = 0
        Me._oCol_169.Name = "_oCol_169"
        Me._oCol_169.ReadOnly = True
        Me._oCol_169.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_169.Size = New System.Drawing.Size(17, 25)
        Me._oCol_169.TabIndex = 190
        Me._oCol_169.Text = ""
        '
        '_oCol_168
        '
        Me._oCol_168.AcceptsReturn = True
        Me._oCol_168.AutoSize = False
        Me._oCol_168.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_168.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_168.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_168.Enabled = False
        Me._oCol_168.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_168.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_168.Location = New System.Drawing.Point(104, 160)
        Me._oCol_168.MaxLength = 0
        Me._oCol_168.Name = "_oCol_168"
        Me._oCol_168.ReadOnly = True
        Me._oCol_168.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_168.Size = New System.Drawing.Size(17, 25)
        Me._oCol_168.TabIndex = 189
        Me._oCol_168.Text = ""
        '
        '_oCol_167
        '
        Me._oCol_167.AcceptsReturn = True
        Me._oCol_167.AutoSize = False
        Me._oCol_167.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_167.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_167.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_167.Enabled = False
        Me._oCol_167.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_167.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_167.Location = New System.Drawing.Point(88, 160)
        Me._oCol_167.MaxLength = 0
        Me._oCol_167.Name = "_oCol_167"
        Me._oCol_167.ReadOnly = True
        Me._oCol_167.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_167.Size = New System.Drawing.Size(17, 25)
        Me._oCol_167.TabIndex = 188
        Me._oCol_167.Text = ""
        '
        '_oCol_166
        '
        Me._oCol_166.AcceptsReturn = True
        Me._oCol_166.AutoSize = False
        Me._oCol_166.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_166.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_166.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_166.Enabled = False
        Me._oCol_166.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_166.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_166.Location = New System.Drawing.Point(72, 160)
        Me._oCol_166.MaxLength = 0
        Me._oCol_166.Name = "_oCol_166"
        Me._oCol_166.ReadOnly = True
        Me._oCol_166.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_166.Size = New System.Drawing.Size(17, 25)
        Me._oCol_166.TabIndex = 187
        Me._oCol_166.Text = ""
        '
        '_oCol_165
        '
        Me._oCol_165.AcceptsReturn = True
        Me._oCol_165.AutoSize = False
        Me._oCol_165.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_165.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_165.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_165.Enabled = False
        Me._oCol_165.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_165.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_165.Location = New System.Drawing.Point(56, 160)
        Me._oCol_165.MaxLength = 0
        Me._oCol_165.Name = "_oCol_165"
        Me._oCol_165.ReadOnly = True
        Me._oCol_165.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_165.Size = New System.Drawing.Size(17, 25)
        Me._oCol_165.TabIndex = 186
        Me._oCol_165.Text = ""
        '
        '_oCol_164
        '
        Me._oCol_164.AcceptsReturn = True
        Me._oCol_164.AutoSize = False
        Me._oCol_164.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_164.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_164.Enabled = False
        Me._oCol_164.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_164.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_164.Location = New System.Drawing.Point(40, 160)
        Me._oCol_164.MaxLength = 0
        Me._oCol_164.Name = "_oCol_164"
        Me._oCol_164.ReadOnly = True
        Me._oCol_164.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_164.Size = New System.Drawing.Size(17, 25)
        Me._oCol_164.TabIndex = 185
        Me._oCol_164.Text = ""
        '
        '_oCol_163
        '
        Me._oCol_163.AcceptsReturn = True
        Me._oCol_163.AutoSize = False
        Me._oCol_163.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_163.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_163.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_163.Enabled = False
        Me._oCol_163.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_163.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_163.Location = New System.Drawing.Point(24, 160)
        Me._oCol_163.MaxLength = 0
        Me._oCol_163.Name = "_oCol_163"
        Me._oCol_163.ReadOnly = True
        Me._oCol_163.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_163.Size = New System.Drawing.Size(17, 25)
        Me._oCol_163.TabIndex = 184
        Me._oCol_163.Text = ""
        '
        '_oCol_162
        '
        Me._oCol_162.AcceptsReturn = True
        Me._oCol_162.AutoSize = False
        Me._oCol_162.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_162.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_162.Enabled = False
        Me._oCol_162.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_162.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_162.Location = New System.Drawing.Point(8, 160)
        Me._oCol_162.MaxLength = 0
        Me._oCol_162.Name = "_oCol_162"
        Me._oCol_162.ReadOnly = True
        Me._oCol_162.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_162.Size = New System.Drawing.Size(17, 25)
        Me._oCol_162.TabIndex = 183
        Me._oCol_162.Text = ""
        '
        '_oCol_161
        '
        Me._oCol_161.AcceptsReturn = True
        Me._oCol_161.AutoSize = False
        Me._oCol_161.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_161.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_161.Enabled = False
        Me._oCol_161.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_161.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_161.Location = New System.Drawing.Point(424, 136)
        Me._oCol_161.MaxLength = 0
        Me._oCol_161.Name = "_oCol_161"
        Me._oCol_161.ReadOnly = True
        Me._oCol_161.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_161.Size = New System.Drawing.Size(17, 25)
        Me._oCol_161.TabIndex = 182
        Me._oCol_161.Text = ""
        '
        '_oCol_160
        '
        Me._oCol_160.AcceptsReturn = True
        Me._oCol_160.AutoSize = False
        Me._oCol_160.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_160.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_160.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_160.Enabled = False
        Me._oCol_160.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_160.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_160.Location = New System.Drawing.Point(408, 136)
        Me._oCol_160.MaxLength = 0
        Me._oCol_160.Name = "_oCol_160"
        Me._oCol_160.ReadOnly = True
        Me._oCol_160.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_160.Size = New System.Drawing.Size(17, 25)
        Me._oCol_160.TabIndex = 181
        Me._oCol_160.Text = ""
        '
        '_oCol_159
        '
        Me._oCol_159.AcceptsReturn = True
        Me._oCol_159.AutoSize = False
        Me._oCol_159.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_159.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_159.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_159.Enabled = False
        Me._oCol_159.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_159.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_159.Location = New System.Drawing.Point(392, 136)
        Me._oCol_159.MaxLength = 0
        Me._oCol_159.Name = "_oCol_159"
        Me._oCol_159.ReadOnly = True
        Me._oCol_159.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_159.Size = New System.Drawing.Size(17, 25)
        Me._oCol_159.TabIndex = 180
        Me._oCol_159.Text = ""
        '
        '_oCol_158
        '
        Me._oCol_158.AcceptsReturn = True
        Me._oCol_158.AutoSize = False
        Me._oCol_158.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_158.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_158.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_158.Enabled = False
        Me._oCol_158.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_158.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_158.Location = New System.Drawing.Point(376, 136)
        Me._oCol_158.MaxLength = 0
        Me._oCol_158.Name = "_oCol_158"
        Me._oCol_158.ReadOnly = True
        Me._oCol_158.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_158.Size = New System.Drawing.Size(17, 25)
        Me._oCol_158.TabIndex = 179
        Me._oCol_158.Text = ""
        '
        '_oCol_157
        '
        Me._oCol_157.AcceptsReturn = True
        Me._oCol_157.AutoSize = False
        Me._oCol_157.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_157.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_157.Enabled = False
        Me._oCol_157.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_157.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_157.Location = New System.Drawing.Point(360, 136)
        Me._oCol_157.MaxLength = 0
        Me._oCol_157.Name = "_oCol_157"
        Me._oCol_157.ReadOnly = True
        Me._oCol_157.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_157.Size = New System.Drawing.Size(17, 25)
        Me._oCol_157.TabIndex = 178
        Me._oCol_157.Text = ""
        '
        '_oCol_156
        '
        Me._oCol_156.AcceptsReturn = True
        Me._oCol_156.AutoSize = False
        Me._oCol_156.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_156.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_156.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_156.Enabled = False
        Me._oCol_156.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_156.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_156.Location = New System.Drawing.Point(344, 136)
        Me._oCol_156.MaxLength = 0
        Me._oCol_156.Name = "_oCol_156"
        Me._oCol_156.ReadOnly = True
        Me._oCol_156.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_156.Size = New System.Drawing.Size(17, 25)
        Me._oCol_156.TabIndex = 177
        Me._oCol_156.Text = ""
        '
        '_oCol_155
        '
        Me._oCol_155.AcceptsReturn = True
        Me._oCol_155.AutoSize = False
        Me._oCol_155.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_155.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_155.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_155.Enabled = False
        Me._oCol_155.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_155.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_155.Location = New System.Drawing.Point(328, 136)
        Me._oCol_155.MaxLength = 0
        Me._oCol_155.Name = "_oCol_155"
        Me._oCol_155.ReadOnly = True
        Me._oCol_155.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_155.Size = New System.Drawing.Size(17, 25)
        Me._oCol_155.TabIndex = 176
        Me._oCol_155.Text = ""
        '
        '_oCol_154
        '
        Me._oCol_154.AcceptsReturn = True
        Me._oCol_154.AutoSize = False
        Me._oCol_154.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_154.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_154.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_154.Enabled = False
        Me._oCol_154.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_154.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_154.Location = New System.Drawing.Point(312, 136)
        Me._oCol_154.MaxLength = 0
        Me._oCol_154.Name = "_oCol_154"
        Me._oCol_154.ReadOnly = True
        Me._oCol_154.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_154.Size = New System.Drawing.Size(17, 25)
        Me._oCol_154.TabIndex = 175
        Me._oCol_154.Text = ""
        '
        '_oCol_153
        '
        Me._oCol_153.AcceptsReturn = True
        Me._oCol_153.AutoSize = False
        Me._oCol_153.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_153.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_153.Enabled = False
        Me._oCol_153.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_153.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_153.Location = New System.Drawing.Point(296, 136)
        Me._oCol_153.MaxLength = 0
        Me._oCol_153.Name = "_oCol_153"
        Me._oCol_153.ReadOnly = True
        Me._oCol_153.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_153.Size = New System.Drawing.Size(17, 25)
        Me._oCol_153.TabIndex = 174
        Me._oCol_153.Text = ""
        '
        '_oCol_152
        '
        Me._oCol_152.AcceptsReturn = True
        Me._oCol_152.AutoSize = False
        Me._oCol_152.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_152.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_152.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_152.Enabled = False
        Me._oCol_152.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_152.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_152.Location = New System.Drawing.Point(280, 136)
        Me._oCol_152.MaxLength = 0
        Me._oCol_152.Name = "_oCol_152"
        Me._oCol_152.ReadOnly = True
        Me._oCol_152.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_152.Size = New System.Drawing.Size(17, 25)
        Me._oCol_152.TabIndex = 173
        Me._oCol_152.Text = ""
        '
        '_oCol_151
        '
        Me._oCol_151.AcceptsReturn = True
        Me._oCol_151.AutoSize = False
        Me._oCol_151.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_151.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_151.Enabled = False
        Me._oCol_151.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_151.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_151.Location = New System.Drawing.Point(264, 136)
        Me._oCol_151.MaxLength = 0
        Me._oCol_151.Name = "_oCol_151"
        Me._oCol_151.ReadOnly = True
        Me._oCol_151.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_151.Size = New System.Drawing.Size(17, 25)
        Me._oCol_151.TabIndex = 172
        Me._oCol_151.Text = ""
        '
        '_oCol_150
        '
        Me._oCol_150.AcceptsReturn = True
        Me._oCol_150.AutoSize = False
        Me._oCol_150.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_150.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_150.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_150.Enabled = False
        Me._oCol_150.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_150.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_150.Location = New System.Drawing.Point(248, 136)
        Me._oCol_150.MaxLength = 0
        Me._oCol_150.Name = "_oCol_150"
        Me._oCol_150.ReadOnly = True
        Me._oCol_150.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_150.Size = New System.Drawing.Size(17, 25)
        Me._oCol_150.TabIndex = 171
        Me._oCol_150.Text = ""
        '
        '_oCol_149
        '
        Me._oCol_149.AcceptsReturn = True
        Me._oCol_149.AutoSize = False
        Me._oCol_149.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_149.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_149.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_149.Enabled = False
        Me._oCol_149.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_149.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_149.Location = New System.Drawing.Point(232, 136)
        Me._oCol_149.MaxLength = 0
        Me._oCol_149.Name = "_oCol_149"
        Me._oCol_149.ReadOnly = True
        Me._oCol_149.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_149.Size = New System.Drawing.Size(17, 25)
        Me._oCol_149.TabIndex = 170
        Me._oCol_149.Text = ""
        '
        '_oCol_148
        '
        Me._oCol_148.AcceptsReturn = True
        Me._oCol_148.AutoSize = False
        Me._oCol_148.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_148.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_148.Enabled = False
        Me._oCol_148.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_148.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_148.Location = New System.Drawing.Point(216, 136)
        Me._oCol_148.MaxLength = 0
        Me._oCol_148.Name = "_oCol_148"
        Me._oCol_148.ReadOnly = True
        Me._oCol_148.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_148.Size = New System.Drawing.Size(17, 25)
        Me._oCol_148.TabIndex = 169
        Me._oCol_148.Text = ""
        '
        '_oCol_147
        '
        Me._oCol_147.AcceptsReturn = True
        Me._oCol_147.AutoSize = False
        Me._oCol_147.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_147.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_147.Enabled = False
        Me._oCol_147.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_147.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_147.Location = New System.Drawing.Point(200, 136)
        Me._oCol_147.MaxLength = 0
        Me._oCol_147.Name = "_oCol_147"
        Me._oCol_147.ReadOnly = True
        Me._oCol_147.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_147.Size = New System.Drawing.Size(17, 25)
        Me._oCol_147.TabIndex = 168
        Me._oCol_147.Text = ""
        '
        '_oCol_146
        '
        Me._oCol_146.AcceptsReturn = True
        Me._oCol_146.AutoSize = False
        Me._oCol_146.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_146.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_146.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_146.Enabled = False
        Me._oCol_146.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_146.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_146.Location = New System.Drawing.Point(184, 136)
        Me._oCol_146.MaxLength = 0
        Me._oCol_146.Name = "_oCol_146"
        Me._oCol_146.ReadOnly = True
        Me._oCol_146.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_146.Size = New System.Drawing.Size(17, 25)
        Me._oCol_146.TabIndex = 167
        Me._oCol_146.Text = ""
        '
        '_oCol_145
        '
        Me._oCol_145.AcceptsReturn = True
        Me._oCol_145.AutoSize = False
        Me._oCol_145.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_145.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_145.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_145.Enabled = False
        Me._oCol_145.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_145.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_145.Location = New System.Drawing.Point(168, 136)
        Me._oCol_145.MaxLength = 0
        Me._oCol_145.Name = "_oCol_145"
        Me._oCol_145.ReadOnly = True
        Me._oCol_145.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_145.Size = New System.Drawing.Size(17, 25)
        Me._oCol_145.TabIndex = 166
        Me._oCol_145.Text = ""
        '
        '_oCol_144
        '
        Me._oCol_144.AcceptsReturn = True
        Me._oCol_144.AutoSize = False
        Me._oCol_144.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_144.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_144.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_144.Enabled = False
        Me._oCol_144.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_144.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_144.Location = New System.Drawing.Point(152, 136)
        Me._oCol_144.MaxLength = 0
        Me._oCol_144.Name = "_oCol_144"
        Me._oCol_144.ReadOnly = True
        Me._oCol_144.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_144.Size = New System.Drawing.Size(17, 25)
        Me._oCol_144.TabIndex = 165
        Me._oCol_144.Text = ""
        '
        '_oCol_143
        '
        Me._oCol_143.AcceptsReturn = True
        Me._oCol_143.AutoSize = False
        Me._oCol_143.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_143.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_143.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_143.Enabled = False
        Me._oCol_143.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_143.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_143.Location = New System.Drawing.Point(136, 136)
        Me._oCol_143.MaxLength = 0
        Me._oCol_143.Name = "_oCol_143"
        Me._oCol_143.ReadOnly = True
        Me._oCol_143.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_143.Size = New System.Drawing.Size(17, 25)
        Me._oCol_143.TabIndex = 164
        Me._oCol_143.Text = ""
        '
        '_oCol_142
        '
        Me._oCol_142.AcceptsReturn = True
        Me._oCol_142.AutoSize = False
        Me._oCol_142.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_142.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_142.Enabled = False
        Me._oCol_142.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_142.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_142.Location = New System.Drawing.Point(120, 136)
        Me._oCol_142.MaxLength = 0
        Me._oCol_142.Name = "_oCol_142"
        Me._oCol_142.ReadOnly = True
        Me._oCol_142.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_142.Size = New System.Drawing.Size(17, 25)
        Me._oCol_142.TabIndex = 163
        Me._oCol_142.Text = ""
        '
        '_oCol_141
        '
        Me._oCol_141.AcceptsReturn = True
        Me._oCol_141.AutoSize = False
        Me._oCol_141.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_141.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_141.Enabled = False
        Me._oCol_141.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_141.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_141.Location = New System.Drawing.Point(104, 136)
        Me._oCol_141.MaxLength = 0
        Me._oCol_141.Name = "_oCol_141"
        Me._oCol_141.ReadOnly = True
        Me._oCol_141.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_141.Size = New System.Drawing.Size(17, 25)
        Me._oCol_141.TabIndex = 162
        Me._oCol_141.Text = ""
        '
        '_oCol_140
        '
        Me._oCol_140.AcceptsReturn = True
        Me._oCol_140.AutoSize = False
        Me._oCol_140.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_140.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_140.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_140.Enabled = False
        Me._oCol_140.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_140.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_140.Location = New System.Drawing.Point(88, 136)
        Me._oCol_140.MaxLength = 0
        Me._oCol_140.Name = "_oCol_140"
        Me._oCol_140.ReadOnly = True
        Me._oCol_140.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_140.Size = New System.Drawing.Size(17, 25)
        Me._oCol_140.TabIndex = 161
        Me._oCol_140.Text = ""
        '
        '_oCol_139
        '
        Me._oCol_139.AcceptsReturn = True
        Me._oCol_139.AutoSize = False
        Me._oCol_139.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_139.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_139.Enabled = False
        Me._oCol_139.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_139.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_139.Location = New System.Drawing.Point(72, 136)
        Me._oCol_139.MaxLength = 0
        Me._oCol_139.Name = "_oCol_139"
        Me._oCol_139.ReadOnly = True
        Me._oCol_139.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_139.Size = New System.Drawing.Size(17, 25)
        Me._oCol_139.TabIndex = 160
        Me._oCol_139.Text = ""
        '
        '_oCol_138
        '
        Me._oCol_138.AcceptsReturn = True
        Me._oCol_138.AutoSize = False
        Me._oCol_138.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_138.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_138.Enabled = False
        Me._oCol_138.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_138.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_138.Location = New System.Drawing.Point(56, 136)
        Me._oCol_138.MaxLength = 0
        Me._oCol_138.Name = "_oCol_138"
        Me._oCol_138.ReadOnly = True
        Me._oCol_138.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_138.Size = New System.Drawing.Size(17, 25)
        Me._oCol_138.TabIndex = 159
        Me._oCol_138.Text = ""
        '
        '_oCol_137
        '
        Me._oCol_137.AcceptsReturn = True
        Me._oCol_137.AutoSize = False
        Me._oCol_137.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_137.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_137.Enabled = False
        Me._oCol_137.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_137.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_137.Location = New System.Drawing.Point(40, 136)
        Me._oCol_137.MaxLength = 0
        Me._oCol_137.Name = "_oCol_137"
        Me._oCol_137.ReadOnly = True
        Me._oCol_137.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_137.Size = New System.Drawing.Size(17, 25)
        Me._oCol_137.TabIndex = 158
        Me._oCol_137.Text = ""
        '
        '_oCol_136
        '
        Me._oCol_136.AcceptsReturn = True
        Me._oCol_136.AutoSize = False
        Me._oCol_136.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_136.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_136.Enabled = False
        Me._oCol_136.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_136.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_136.Location = New System.Drawing.Point(24, 136)
        Me._oCol_136.MaxLength = 0
        Me._oCol_136.Name = "_oCol_136"
        Me._oCol_136.ReadOnly = True
        Me._oCol_136.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_136.Size = New System.Drawing.Size(17, 25)
        Me._oCol_136.TabIndex = 157
        Me._oCol_136.Text = ""
        '
        '_oCol_135
        '
        Me._oCol_135.AcceptsReturn = True
        Me._oCol_135.AutoSize = False
        Me._oCol_135.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_135.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_135.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_135.Enabled = False
        Me._oCol_135.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_135.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_135.Location = New System.Drawing.Point(8, 136)
        Me._oCol_135.MaxLength = 0
        Me._oCol_135.Name = "_oCol_135"
        Me._oCol_135.ReadOnly = True
        Me._oCol_135.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_135.Size = New System.Drawing.Size(17, 25)
        Me._oCol_135.TabIndex = 156
        Me._oCol_135.Text = ""
        '
        '_oCol_107
        '
        Me._oCol_107.AcceptsReturn = True
        Me._oCol_107.AutoSize = False
        Me._oCol_107.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_107.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_107.Enabled = False
        Me._oCol_107.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_107.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_107.Location = New System.Drawing.Point(424, 88)
        Me._oCol_107.MaxLength = 0
        Me._oCol_107.Name = "_oCol_107"
        Me._oCol_107.ReadOnly = True
        Me._oCol_107.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_107.Size = New System.Drawing.Size(17, 25)
        Me._oCol_107.TabIndex = 128
        Me._oCol_107.Text = ""
        '
        '_oCol_106
        '
        Me._oCol_106.AcceptsReturn = True
        Me._oCol_106.AutoSize = False
        Me._oCol_106.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_106.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_106.Enabled = False
        Me._oCol_106.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_106.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_106.Location = New System.Drawing.Point(408, 88)
        Me._oCol_106.MaxLength = 0
        Me._oCol_106.Name = "_oCol_106"
        Me._oCol_106.ReadOnly = True
        Me._oCol_106.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_106.Size = New System.Drawing.Size(17, 25)
        Me._oCol_106.TabIndex = 127
        Me._oCol_106.Text = ""
        '
        '_oCol_105
        '
        Me._oCol_105.AcceptsReturn = True
        Me._oCol_105.AutoSize = False
        Me._oCol_105.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_105.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_105.Enabled = False
        Me._oCol_105.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_105.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_105.Location = New System.Drawing.Point(392, 88)
        Me._oCol_105.MaxLength = 0
        Me._oCol_105.Name = "_oCol_105"
        Me._oCol_105.ReadOnly = True
        Me._oCol_105.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_105.Size = New System.Drawing.Size(17, 25)
        Me._oCol_105.TabIndex = 126
        Me._oCol_105.Text = ""
        '
        '_oCol_104
        '
        Me._oCol_104.AcceptsReturn = True
        Me._oCol_104.AutoSize = False
        Me._oCol_104.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_104.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_104.Enabled = False
        Me._oCol_104.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_104.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_104.Location = New System.Drawing.Point(376, 88)
        Me._oCol_104.MaxLength = 0
        Me._oCol_104.Name = "_oCol_104"
        Me._oCol_104.ReadOnly = True
        Me._oCol_104.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_104.Size = New System.Drawing.Size(17, 25)
        Me._oCol_104.TabIndex = 125
        Me._oCol_104.Text = ""
        '
        '_oCol_103
        '
        Me._oCol_103.AcceptsReturn = True
        Me._oCol_103.AutoSize = False
        Me._oCol_103.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_103.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_103.Enabled = False
        Me._oCol_103.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_103.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_103.Location = New System.Drawing.Point(360, 88)
        Me._oCol_103.MaxLength = 0
        Me._oCol_103.Name = "_oCol_103"
        Me._oCol_103.ReadOnly = True
        Me._oCol_103.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_103.Size = New System.Drawing.Size(17, 25)
        Me._oCol_103.TabIndex = 124
        Me._oCol_103.Text = ""
        '
        '_oCol_102
        '
        Me._oCol_102.AcceptsReturn = True
        Me._oCol_102.AutoSize = False
        Me._oCol_102.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_102.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_102.Enabled = False
        Me._oCol_102.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_102.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_102.Location = New System.Drawing.Point(344, 88)
        Me._oCol_102.MaxLength = 0
        Me._oCol_102.Name = "_oCol_102"
        Me._oCol_102.ReadOnly = True
        Me._oCol_102.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_102.Size = New System.Drawing.Size(17, 25)
        Me._oCol_102.TabIndex = 123
        Me._oCol_102.Text = ""
        '
        '_oCol_101
        '
        Me._oCol_101.AcceptsReturn = True
        Me._oCol_101.AutoSize = False
        Me._oCol_101.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_101.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_101.Enabled = False
        Me._oCol_101.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_101.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_101.Location = New System.Drawing.Point(328, 88)
        Me._oCol_101.MaxLength = 0
        Me._oCol_101.Name = "_oCol_101"
        Me._oCol_101.ReadOnly = True
        Me._oCol_101.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_101.Size = New System.Drawing.Size(17, 25)
        Me._oCol_101.TabIndex = 122
        Me._oCol_101.Text = ""
        '
        '_oCol_100
        '
        Me._oCol_100.AcceptsReturn = True
        Me._oCol_100.AutoSize = False
        Me._oCol_100.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_100.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_100.Enabled = False
        Me._oCol_100.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_100.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_100.Location = New System.Drawing.Point(312, 88)
        Me._oCol_100.MaxLength = 0
        Me._oCol_100.Name = "_oCol_100"
        Me._oCol_100.ReadOnly = True
        Me._oCol_100.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_100.Size = New System.Drawing.Size(17, 25)
        Me._oCol_100.TabIndex = 121
        Me._oCol_100.Text = ""
        '
        '_oCol_99
        '
        Me._oCol_99.AcceptsReturn = True
        Me._oCol_99.AutoSize = False
        Me._oCol_99.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_99.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_99.Enabled = False
        Me._oCol_99.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_99.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_99.Location = New System.Drawing.Point(296, 88)
        Me._oCol_99.MaxLength = 0
        Me._oCol_99.Name = "_oCol_99"
        Me._oCol_99.ReadOnly = True
        Me._oCol_99.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_99.Size = New System.Drawing.Size(17, 25)
        Me._oCol_99.TabIndex = 120
        Me._oCol_99.Text = ""
        '
        '_oCol_98
        '
        Me._oCol_98.AcceptsReturn = True
        Me._oCol_98.AutoSize = False
        Me._oCol_98.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_98.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_98.Enabled = False
        Me._oCol_98.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_98.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_98.Location = New System.Drawing.Point(280, 88)
        Me._oCol_98.MaxLength = 0
        Me._oCol_98.Name = "_oCol_98"
        Me._oCol_98.ReadOnly = True
        Me._oCol_98.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_98.Size = New System.Drawing.Size(17, 25)
        Me._oCol_98.TabIndex = 119
        Me._oCol_98.Text = ""
        '
        '_oCol_97
        '
        Me._oCol_97.AcceptsReturn = True
        Me._oCol_97.AutoSize = False
        Me._oCol_97.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_97.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_97.Enabled = False
        Me._oCol_97.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_97.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_97.Location = New System.Drawing.Point(264, 88)
        Me._oCol_97.MaxLength = 0
        Me._oCol_97.Name = "_oCol_97"
        Me._oCol_97.ReadOnly = True
        Me._oCol_97.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_97.Size = New System.Drawing.Size(17, 25)
        Me._oCol_97.TabIndex = 118
        Me._oCol_97.Text = ""
        '
        '_oCol_96
        '
        Me._oCol_96.AcceptsReturn = True
        Me._oCol_96.AutoSize = False
        Me._oCol_96.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_96.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_96.Enabled = False
        Me._oCol_96.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_96.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_96.Location = New System.Drawing.Point(248, 88)
        Me._oCol_96.MaxLength = 0
        Me._oCol_96.Name = "_oCol_96"
        Me._oCol_96.ReadOnly = True
        Me._oCol_96.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_96.Size = New System.Drawing.Size(17, 25)
        Me._oCol_96.TabIndex = 117
        Me._oCol_96.Text = ""
        '
        '_oCol_95
        '
        Me._oCol_95.AcceptsReturn = True
        Me._oCol_95.AutoSize = False
        Me._oCol_95.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_95.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_95.Enabled = False
        Me._oCol_95.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_95.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_95.Location = New System.Drawing.Point(232, 88)
        Me._oCol_95.MaxLength = 0
        Me._oCol_95.Name = "_oCol_95"
        Me._oCol_95.ReadOnly = True
        Me._oCol_95.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_95.Size = New System.Drawing.Size(17, 25)
        Me._oCol_95.TabIndex = 116
        Me._oCol_95.Text = ""
        '
        '_oCol_94
        '
        Me._oCol_94.AcceptsReturn = True
        Me._oCol_94.AutoSize = False
        Me._oCol_94.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_94.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_94.Enabled = False
        Me._oCol_94.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_94.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_94.Location = New System.Drawing.Point(216, 88)
        Me._oCol_94.MaxLength = 0
        Me._oCol_94.Name = "_oCol_94"
        Me._oCol_94.ReadOnly = True
        Me._oCol_94.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_94.Size = New System.Drawing.Size(17, 25)
        Me._oCol_94.TabIndex = 115
        Me._oCol_94.Text = ""
        '
        '_oCol_93
        '
        Me._oCol_93.AcceptsReturn = True
        Me._oCol_93.AutoSize = False
        Me._oCol_93.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_93.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_93.Enabled = False
        Me._oCol_93.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_93.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_93.Location = New System.Drawing.Point(200, 88)
        Me._oCol_93.MaxLength = 0
        Me._oCol_93.Name = "_oCol_93"
        Me._oCol_93.ReadOnly = True
        Me._oCol_93.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_93.Size = New System.Drawing.Size(17, 25)
        Me._oCol_93.TabIndex = 114
        Me._oCol_93.Text = ""
        '
        '_oCol_92
        '
        Me._oCol_92.AcceptsReturn = True
        Me._oCol_92.AutoSize = False
        Me._oCol_92.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_92.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_92.Enabled = False
        Me._oCol_92.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_92.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_92.Location = New System.Drawing.Point(184, 88)
        Me._oCol_92.MaxLength = 0
        Me._oCol_92.Name = "_oCol_92"
        Me._oCol_92.ReadOnly = True
        Me._oCol_92.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_92.Size = New System.Drawing.Size(17, 25)
        Me._oCol_92.TabIndex = 113
        Me._oCol_92.Text = ""
        '
        '_oCol_91
        '
        Me._oCol_91.AcceptsReturn = True
        Me._oCol_91.AutoSize = False
        Me._oCol_91.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_91.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_91.Enabled = False
        Me._oCol_91.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_91.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_91.Location = New System.Drawing.Point(168, 88)
        Me._oCol_91.MaxLength = 0
        Me._oCol_91.Name = "_oCol_91"
        Me._oCol_91.ReadOnly = True
        Me._oCol_91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_91.Size = New System.Drawing.Size(17, 25)
        Me._oCol_91.TabIndex = 112
        Me._oCol_91.Text = ""
        '
        '_oCol_90
        '
        Me._oCol_90.AcceptsReturn = True
        Me._oCol_90.AutoSize = False
        Me._oCol_90.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_90.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_90.Enabled = False
        Me._oCol_90.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_90.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_90.Location = New System.Drawing.Point(152, 88)
        Me._oCol_90.MaxLength = 0
        Me._oCol_90.Name = "_oCol_90"
        Me._oCol_90.ReadOnly = True
        Me._oCol_90.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_90.Size = New System.Drawing.Size(17, 25)
        Me._oCol_90.TabIndex = 111
        Me._oCol_90.Text = ""
        '
        '_oCol_89
        '
        Me._oCol_89.AcceptsReturn = True
        Me._oCol_89.AutoSize = False
        Me._oCol_89.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_89.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_89.Enabled = False
        Me._oCol_89.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_89.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_89.Location = New System.Drawing.Point(136, 88)
        Me._oCol_89.MaxLength = 0
        Me._oCol_89.Name = "_oCol_89"
        Me._oCol_89.ReadOnly = True
        Me._oCol_89.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_89.Size = New System.Drawing.Size(17, 25)
        Me._oCol_89.TabIndex = 110
        Me._oCol_89.Text = ""
        '
        '_oCol_88
        '
        Me._oCol_88.AcceptsReturn = True
        Me._oCol_88.AutoSize = False
        Me._oCol_88.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_88.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_88.Enabled = False
        Me._oCol_88.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_88.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_88.Location = New System.Drawing.Point(120, 88)
        Me._oCol_88.MaxLength = 0
        Me._oCol_88.Name = "_oCol_88"
        Me._oCol_88.ReadOnly = True
        Me._oCol_88.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_88.Size = New System.Drawing.Size(17, 25)
        Me._oCol_88.TabIndex = 109
        Me._oCol_88.Text = ""
        '
        '_oCol_87
        '
        Me._oCol_87.AcceptsReturn = True
        Me._oCol_87.AutoSize = False
        Me._oCol_87.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_87.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_87.Enabled = False
        Me._oCol_87.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_87.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_87.Location = New System.Drawing.Point(104, 88)
        Me._oCol_87.MaxLength = 0
        Me._oCol_87.Name = "_oCol_87"
        Me._oCol_87.ReadOnly = True
        Me._oCol_87.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_87.Size = New System.Drawing.Size(17, 25)
        Me._oCol_87.TabIndex = 108
        Me._oCol_87.Text = ""
        '
        '_oCol_86
        '
        Me._oCol_86.AcceptsReturn = True
        Me._oCol_86.AutoSize = False
        Me._oCol_86.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_86.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_86.Enabled = False
        Me._oCol_86.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_86.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_86.Location = New System.Drawing.Point(88, 88)
        Me._oCol_86.MaxLength = 0
        Me._oCol_86.Name = "_oCol_86"
        Me._oCol_86.ReadOnly = True
        Me._oCol_86.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_86.Size = New System.Drawing.Size(17, 25)
        Me._oCol_86.TabIndex = 107
        Me._oCol_86.Text = ""
        '
        '_oCol_85
        '
        Me._oCol_85.AcceptsReturn = True
        Me._oCol_85.AutoSize = False
        Me._oCol_85.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_85.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_85.Enabled = False
        Me._oCol_85.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_85.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_85.Location = New System.Drawing.Point(72, 88)
        Me._oCol_85.MaxLength = 0
        Me._oCol_85.Name = "_oCol_85"
        Me._oCol_85.ReadOnly = True
        Me._oCol_85.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_85.Size = New System.Drawing.Size(17, 25)
        Me._oCol_85.TabIndex = 106
        Me._oCol_85.Text = ""
        '
        '_oCol_84
        '
        Me._oCol_84.AcceptsReturn = True
        Me._oCol_84.AutoSize = False
        Me._oCol_84.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_84.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_84.Enabled = False
        Me._oCol_84.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_84.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_84.Location = New System.Drawing.Point(56, 88)
        Me._oCol_84.MaxLength = 0
        Me._oCol_84.Name = "_oCol_84"
        Me._oCol_84.ReadOnly = True
        Me._oCol_84.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_84.Size = New System.Drawing.Size(17, 25)
        Me._oCol_84.TabIndex = 105
        Me._oCol_84.Text = ""
        '
        '_oCol_83
        '
        Me._oCol_83.AcceptsReturn = True
        Me._oCol_83.AutoSize = False
        Me._oCol_83.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_83.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_83.Enabled = False
        Me._oCol_83.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_83.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_83.Location = New System.Drawing.Point(40, 88)
        Me._oCol_83.MaxLength = 0
        Me._oCol_83.Name = "_oCol_83"
        Me._oCol_83.ReadOnly = True
        Me._oCol_83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_83.Size = New System.Drawing.Size(17, 25)
        Me._oCol_83.TabIndex = 104
        Me._oCol_83.Text = ""
        '
        '_oCol_82
        '
        Me._oCol_82.AcceptsReturn = True
        Me._oCol_82.AutoSize = False
        Me._oCol_82.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_82.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_82.Enabled = False
        Me._oCol_82.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_82.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_82.Location = New System.Drawing.Point(24, 88)
        Me._oCol_82.MaxLength = 0
        Me._oCol_82.Name = "_oCol_82"
        Me._oCol_82.ReadOnly = True
        Me._oCol_82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_82.Size = New System.Drawing.Size(17, 25)
        Me._oCol_82.TabIndex = 103
        Me._oCol_82.Text = ""
        '
        '_oCol_81
        '
        Me._oCol_81.AcceptsReturn = True
        Me._oCol_81.AutoSize = False
        Me._oCol_81.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_81.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_81.Enabled = False
        Me._oCol_81.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_81.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_81.Location = New System.Drawing.Point(8, 88)
        Me._oCol_81.MaxLength = 0
        Me._oCol_81.Name = "_oCol_81"
        Me._oCol_81.ReadOnly = True
        Me._oCol_81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_81.Size = New System.Drawing.Size(17, 25)
        Me._oCol_81.TabIndex = 102
        Me._oCol_81.Text = ""
        '
        '_oCol_80
        '
        Me._oCol_80.AcceptsReturn = True
        Me._oCol_80.AutoSize = False
        Me._oCol_80.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_80.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_80.Enabled = False
        Me._oCol_80.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_80.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_80.Location = New System.Drawing.Point(424, 64)
        Me._oCol_80.MaxLength = 0
        Me._oCol_80.Name = "_oCol_80"
        Me._oCol_80.ReadOnly = True
        Me._oCol_80.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_80.Size = New System.Drawing.Size(17, 25)
        Me._oCol_80.TabIndex = 101
        Me._oCol_80.Text = ""
        '
        '_oCol_79
        '
        Me._oCol_79.AcceptsReturn = True
        Me._oCol_79.AutoSize = False
        Me._oCol_79.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_79.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_79.Enabled = False
        Me._oCol_79.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_79.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_79.Location = New System.Drawing.Point(408, 64)
        Me._oCol_79.MaxLength = 0
        Me._oCol_79.Name = "_oCol_79"
        Me._oCol_79.ReadOnly = True
        Me._oCol_79.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_79.Size = New System.Drawing.Size(17, 25)
        Me._oCol_79.TabIndex = 100
        Me._oCol_79.Text = ""
        '
        '_oCol_78
        '
        Me._oCol_78.AcceptsReturn = True
        Me._oCol_78.AutoSize = False
        Me._oCol_78.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_78.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_78.Enabled = False
        Me._oCol_78.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_78.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_78.Location = New System.Drawing.Point(392, 64)
        Me._oCol_78.MaxLength = 0
        Me._oCol_78.Name = "_oCol_78"
        Me._oCol_78.ReadOnly = True
        Me._oCol_78.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_78.Size = New System.Drawing.Size(17, 25)
        Me._oCol_78.TabIndex = 99
        Me._oCol_78.Text = ""
        '
        '_oCol_77
        '
        Me._oCol_77.AcceptsReturn = True
        Me._oCol_77.AutoSize = False
        Me._oCol_77.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_77.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_77.Enabled = False
        Me._oCol_77.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_77.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_77.Location = New System.Drawing.Point(376, 64)
        Me._oCol_77.MaxLength = 0
        Me._oCol_77.Name = "_oCol_77"
        Me._oCol_77.ReadOnly = True
        Me._oCol_77.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_77.Size = New System.Drawing.Size(17, 25)
        Me._oCol_77.TabIndex = 98
        Me._oCol_77.Text = ""
        '
        '_oCol_76
        '
        Me._oCol_76.AcceptsReturn = True
        Me._oCol_76.AutoSize = False
        Me._oCol_76.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_76.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_76.Enabled = False
        Me._oCol_76.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_76.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_76.Location = New System.Drawing.Point(360, 64)
        Me._oCol_76.MaxLength = 0
        Me._oCol_76.Name = "_oCol_76"
        Me._oCol_76.ReadOnly = True
        Me._oCol_76.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_76.Size = New System.Drawing.Size(17, 25)
        Me._oCol_76.TabIndex = 97
        Me._oCol_76.Text = ""
        '
        '_oCol_75
        '
        Me._oCol_75.AcceptsReturn = True
        Me._oCol_75.AutoSize = False
        Me._oCol_75.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_75.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_75.Enabled = False
        Me._oCol_75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_75.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_75.Location = New System.Drawing.Point(344, 64)
        Me._oCol_75.MaxLength = 0
        Me._oCol_75.Name = "_oCol_75"
        Me._oCol_75.ReadOnly = True
        Me._oCol_75.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_75.Size = New System.Drawing.Size(17, 25)
        Me._oCol_75.TabIndex = 96
        Me._oCol_75.Text = ""
        '
        '_oCol_74
        '
        Me._oCol_74.AcceptsReturn = True
        Me._oCol_74.AutoSize = False
        Me._oCol_74.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_74.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_74.Enabled = False
        Me._oCol_74.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_74.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_74.Location = New System.Drawing.Point(328, 64)
        Me._oCol_74.MaxLength = 0
        Me._oCol_74.Name = "_oCol_74"
        Me._oCol_74.ReadOnly = True
        Me._oCol_74.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_74.Size = New System.Drawing.Size(17, 25)
        Me._oCol_74.TabIndex = 95
        Me._oCol_74.Text = ""
        '
        '_oCol_73
        '
        Me._oCol_73.AcceptsReturn = True
        Me._oCol_73.AutoSize = False
        Me._oCol_73.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_73.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_73.Enabled = False
        Me._oCol_73.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_73.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_73.Location = New System.Drawing.Point(312, 64)
        Me._oCol_73.MaxLength = 0
        Me._oCol_73.Name = "_oCol_73"
        Me._oCol_73.ReadOnly = True
        Me._oCol_73.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_73.Size = New System.Drawing.Size(17, 25)
        Me._oCol_73.TabIndex = 94
        Me._oCol_73.Text = ""
        '
        '_oCol_72
        '
        Me._oCol_72.AcceptsReturn = True
        Me._oCol_72.AutoSize = False
        Me._oCol_72.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_72.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_72.Enabled = False
        Me._oCol_72.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_72.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_72.Location = New System.Drawing.Point(296, 64)
        Me._oCol_72.MaxLength = 0
        Me._oCol_72.Name = "_oCol_72"
        Me._oCol_72.ReadOnly = True
        Me._oCol_72.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_72.Size = New System.Drawing.Size(17, 25)
        Me._oCol_72.TabIndex = 93
        Me._oCol_72.Text = ""
        '
        '_oCol_71
        '
        Me._oCol_71.AcceptsReturn = True
        Me._oCol_71.AutoSize = False
        Me._oCol_71.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_71.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_71.Enabled = False
        Me._oCol_71.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_71.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_71.Location = New System.Drawing.Point(280, 64)
        Me._oCol_71.MaxLength = 0
        Me._oCol_71.Name = "_oCol_71"
        Me._oCol_71.ReadOnly = True
        Me._oCol_71.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_71.Size = New System.Drawing.Size(17, 25)
        Me._oCol_71.TabIndex = 92
        Me._oCol_71.Text = ""
        '
        '_oCol_70
        '
        Me._oCol_70.AcceptsReturn = True
        Me._oCol_70.AutoSize = False
        Me._oCol_70.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_70.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_70.Enabled = False
        Me._oCol_70.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_70.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_70.Location = New System.Drawing.Point(264, 64)
        Me._oCol_70.MaxLength = 0
        Me._oCol_70.Name = "_oCol_70"
        Me._oCol_70.ReadOnly = True
        Me._oCol_70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_70.Size = New System.Drawing.Size(17, 25)
        Me._oCol_70.TabIndex = 91
        Me._oCol_70.Text = ""
        '
        '_oCol_69
        '
        Me._oCol_69.AcceptsReturn = True
        Me._oCol_69.AutoSize = False
        Me._oCol_69.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_69.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_69.Enabled = False
        Me._oCol_69.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_69.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_69.Location = New System.Drawing.Point(248, 64)
        Me._oCol_69.MaxLength = 0
        Me._oCol_69.Name = "_oCol_69"
        Me._oCol_69.ReadOnly = True
        Me._oCol_69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_69.Size = New System.Drawing.Size(17, 25)
        Me._oCol_69.TabIndex = 90
        Me._oCol_69.Text = ""
        '
        '_oCol_68
        '
        Me._oCol_68.AcceptsReturn = True
        Me._oCol_68.AutoSize = False
        Me._oCol_68.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_68.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_68.Enabled = False
        Me._oCol_68.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_68.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_68.Location = New System.Drawing.Point(232, 64)
        Me._oCol_68.MaxLength = 0
        Me._oCol_68.Name = "_oCol_68"
        Me._oCol_68.ReadOnly = True
        Me._oCol_68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_68.Size = New System.Drawing.Size(17, 25)
        Me._oCol_68.TabIndex = 89
        Me._oCol_68.Text = ""
        '
        '_oCol_67
        '
        Me._oCol_67.AcceptsReturn = True
        Me._oCol_67.AutoSize = False
        Me._oCol_67.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_67.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_67.Enabled = False
        Me._oCol_67.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_67.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_67.Location = New System.Drawing.Point(216, 64)
        Me._oCol_67.MaxLength = 0
        Me._oCol_67.Name = "_oCol_67"
        Me._oCol_67.ReadOnly = True
        Me._oCol_67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_67.Size = New System.Drawing.Size(17, 25)
        Me._oCol_67.TabIndex = 88
        Me._oCol_67.Text = ""
        '
        '_oCol_66
        '
        Me._oCol_66.AcceptsReturn = True
        Me._oCol_66.AutoSize = False
        Me._oCol_66.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_66.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_66.Enabled = False
        Me._oCol_66.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_66.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_66.Location = New System.Drawing.Point(200, 64)
        Me._oCol_66.MaxLength = 0
        Me._oCol_66.Name = "_oCol_66"
        Me._oCol_66.ReadOnly = True
        Me._oCol_66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_66.Size = New System.Drawing.Size(17, 25)
        Me._oCol_66.TabIndex = 87
        Me._oCol_66.Text = ""
        '
        '_oCol_65
        '
        Me._oCol_65.AcceptsReturn = True
        Me._oCol_65.AutoSize = False
        Me._oCol_65.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_65.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_65.Enabled = False
        Me._oCol_65.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_65.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_65.Location = New System.Drawing.Point(184, 64)
        Me._oCol_65.MaxLength = 0
        Me._oCol_65.Name = "_oCol_65"
        Me._oCol_65.ReadOnly = True
        Me._oCol_65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_65.Size = New System.Drawing.Size(17, 25)
        Me._oCol_65.TabIndex = 86
        Me._oCol_65.Text = ""
        '
        '_oCol_64
        '
        Me._oCol_64.AcceptsReturn = True
        Me._oCol_64.AutoSize = False
        Me._oCol_64.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_64.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_64.Enabled = False
        Me._oCol_64.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_64.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_64.Location = New System.Drawing.Point(168, 64)
        Me._oCol_64.MaxLength = 0
        Me._oCol_64.Name = "_oCol_64"
        Me._oCol_64.ReadOnly = True
        Me._oCol_64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_64.Size = New System.Drawing.Size(17, 25)
        Me._oCol_64.TabIndex = 85
        Me._oCol_64.Text = ""
        '
        '_oCol_63
        '
        Me._oCol_63.AcceptsReturn = True
        Me._oCol_63.AutoSize = False
        Me._oCol_63.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_63.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_63.Enabled = False
        Me._oCol_63.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_63.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_63.Location = New System.Drawing.Point(152, 64)
        Me._oCol_63.MaxLength = 0
        Me._oCol_63.Name = "_oCol_63"
        Me._oCol_63.ReadOnly = True
        Me._oCol_63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_63.Size = New System.Drawing.Size(17, 25)
        Me._oCol_63.TabIndex = 84
        Me._oCol_63.Text = ""
        '
        '_oCol_62
        '
        Me._oCol_62.AcceptsReturn = True
        Me._oCol_62.AutoSize = False
        Me._oCol_62.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_62.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_62.Enabled = False
        Me._oCol_62.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_62.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_62.Location = New System.Drawing.Point(136, 64)
        Me._oCol_62.MaxLength = 0
        Me._oCol_62.Name = "_oCol_62"
        Me._oCol_62.ReadOnly = True
        Me._oCol_62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_62.Size = New System.Drawing.Size(17, 25)
        Me._oCol_62.TabIndex = 83
        Me._oCol_62.Text = ""
        '
        '_oCol_61
        '
        Me._oCol_61.AcceptsReturn = True
        Me._oCol_61.AutoSize = False
        Me._oCol_61.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_61.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_61.Enabled = False
        Me._oCol_61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_61.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_61.Location = New System.Drawing.Point(120, 64)
        Me._oCol_61.MaxLength = 0
        Me._oCol_61.Name = "_oCol_61"
        Me._oCol_61.ReadOnly = True
        Me._oCol_61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_61.Size = New System.Drawing.Size(17, 25)
        Me._oCol_61.TabIndex = 82
        Me._oCol_61.Text = ""
        '
        '_oCol_60
        '
        Me._oCol_60.AcceptsReturn = True
        Me._oCol_60.AutoSize = False
        Me._oCol_60.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_60.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_60.Enabled = False
        Me._oCol_60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_60.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_60.Location = New System.Drawing.Point(104, 64)
        Me._oCol_60.MaxLength = 0
        Me._oCol_60.Name = "_oCol_60"
        Me._oCol_60.ReadOnly = True
        Me._oCol_60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_60.Size = New System.Drawing.Size(17, 25)
        Me._oCol_60.TabIndex = 81
        Me._oCol_60.Text = ""
        '
        '_oCol_59
        '
        Me._oCol_59.AcceptsReturn = True
        Me._oCol_59.AutoSize = False
        Me._oCol_59.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_59.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_59.Enabled = False
        Me._oCol_59.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_59.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_59.Location = New System.Drawing.Point(88, 64)
        Me._oCol_59.MaxLength = 0
        Me._oCol_59.Name = "_oCol_59"
        Me._oCol_59.ReadOnly = True
        Me._oCol_59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_59.Size = New System.Drawing.Size(17, 25)
        Me._oCol_59.TabIndex = 80
        Me._oCol_59.Text = ""
        '
        '_oCol_58
        '
        Me._oCol_58.AcceptsReturn = True
        Me._oCol_58.AutoSize = False
        Me._oCol_58.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_58.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_58.Enabled = False
        Me._oCol_58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_58.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_58.Location = New System.Drawing.Point(72, 64)
        Me._oCol_58.MaxLength = 0
        Me._oCol_58.Name = "_oCol_58"
        Me._oCol_58.ReadOnly = True
        Me._oCol_58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_58.Size = New System.Drawing.Size(17, 25)
        Me._oCol_58.TabIndex = 79
        Me._oCol_58.Text = ""
        '
        '_oCol_57
        '
        Me._oCol_57.AcceptsReturn = True
        Me._oCol_57.AutoSize = False
        Me._oCol_57.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_57.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_57.Enabled = False
        Me._oCol_57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_57.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_57.Location = New System.Drawing.Point(56, 64)
        Me._oCol_57.MaxLength = 0
        Me._oCol_57.Name = "_oCol_57"
        Me._oCol_57.ReadOnly = True
        Me._oCol_57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_57.Size = New System.Drawing.Size(17, 25)
        Me._oCol_57.TabIndex = 78
        Me._oCol_57.Text = ""
        '
        '_oCol_56
        '
        Me._oCol_56.AcceptsReturn = True
        Me._oCol_56.AutoSize = False
        Me._oCol_56.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_56.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_56.Enabled = False
        Me._oCol_56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_56.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_56.Location = New System.Drawing.Point(40, 64)
        Me._oCol_56.MaxLength = 0
        Me._oCol_56.Name = "_oCol_56"
        Me._oCol_56.ReadOnly = True
        Me._oCol_56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_56.Size = New System.Drawing.Size(17, 25)
        Me._oCol_56.TabIndex = 77
        Me._oCol_56.Text = ""
        '
        '_oCol_55
        '
        Me._oCol_55.AcceptsReturn = True
        Me._oCol_55.AutoSize = False
        Me._oCol_55.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_55.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_55.Enabled = False
        Me._oCol_55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_55.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_55.Location = New System.Drawing.Point(24, 64)
        Me._oCol_55.MaxLength = 0
        Me._oCol_55.Name = "_oCol_55"
        Me._oCol_55.ReadOnly = True
        Me._oCol_55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_55.Size = New System.Drawing.Size(17, 25)
        Me._oCol_55.TabIndex = 76
        Me._oCol_55.Text = ""
        '
        '_oCol_54
        '
        Me._oCol_54.AcceptsReturn = True
        Me._oCol_54.AutoSize = False
        Me._oCol_54.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_54.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_54.Enabled = False
        Me._oCol_54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_54.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_54.Location = New System.Drawing.Point(8, 64)
        Me._oCol_54.MaxLength = 0
        Me._oCol_54.Name = "_oCol_54"
        Me._oCol_54.ReadOnly = True
        Me._oCol_54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_54.Size = New System.Drawing.Size(17, 25)
        Me._oCol_54.TabIndex = 75
        Me._oCol_54.Text = ""
        '
        '_oCol_53
        '
        Me._oCol_53.AcceptsReturn = True
        Me._oCol_53.AutoSize = False
        Me._oCol_53.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_53.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_53.Enabled = False
        Me._oCol_53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_53.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_53.Location = New System.Drawing.Point(424, 40)
        Me._oCol_53.MaxLength = 0
        Me._oCol_53.Name = "_oCol_53"
        Me._oCol_53.ReadOnly = True
        Me._oCol_53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_53.Size = New System.Drawing.Size(17, 25)
        Me._oCol_53.TabIndex = 74
        Me._oCol_53.Text = ""
        '
        '_oCol_52
        '
        Me._oCol_52.AcceptsReturn = True
        Me._oCol_52.AutoSize = False
        Me._oCol_52.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_52.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_52.Enabled = False
        Me._oCol_52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_52.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_52.Location = New System.Drawing.Point(408, 40)
        Me._oCol_52.MaxLength = 0
        Me._oCol_52.Name = "_oCol_52"
        Me._oCol_52.ReadOnly = True
        Me._oCol_52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_52.Size = New System.Drawing.Size(17, 25)
        Me._oCol_52.TabIndex = 73
        Me._oCol_52.Text = ""
        '
        '_oCol_51
        '
        Me._oCol_51.AcceptsReturn = True
        Me._oCol_51.AutoSize = False
        Me._oCol_51.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_51.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_51.Enabled = False
        Me._oCol_51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_51.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_51.Location = New System.Drawing.Point(392, 40)
        Me._oCol_51.MaxLength = 0
        Me._oCol_51.Name = "_oCol_51"
        Me._oCol_51.ReadOnly = True
        Me._oCol_51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_51.Size = New System.Drawing.Size(17, 25)
        Me._oCol_51.TabIndex = 72
        Me._oCol_51.Text = ""
        '
        '_oCol_50
        '
        Me._oCol_50.AcceptsReturn = True
        Me._oCol_50.AutoSize = False
        Me._oCol_50.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_50.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_50.Enabled = False
        Me._oCol_50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_50.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_50.Location = New System.Drawing.Point(376, 40)
        Me._oCol_50.MaxLength = 0
        Me._oCol_50.Name = "_oCol_50"
        Me._oCol_50.ReadOnly = True
        Me._oCol_50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_50.Size = New System.Drawing.Size(17, 25)
        Me._oCol_50.TabIndex = 71
        Me._oCol_50.Text = ""
        '
        '_oCol_49
        '
        Me._oCol_49.AcceptsReturn = True
        Me._oCol_49.AutoSize = False
        Me._oCol_49.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_49.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_49.Enabled = False
        Me._oCol_49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_49.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_49.Location = New System.Drawing.Point(360, 40)
        Me._oCol_49.MaxLength = 0
        Me._oCol_49.Name = "_oCol_49"
        Me._oCol_49.ReadOnly = True
        Me._oCol_49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_49.Size = New System.Drawing.Size(17, 25)
        Me._oCol_49.TabIndex = 70
        Me._oCol_49.Text = ""
        '
        '_oCol_48
        '
        Me._oCol_48.AcceptsReturn = True
        Me._oCol_48.AutoSize = False
        Me._oCol_48.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_48.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_48.Enabled = False
        Me._oCol_48.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_48.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_48.Location = New System.Drawing.Point(344, 40)
        Me._oCol_48.MaxLength = 0
        Me._oCol_48.Name = "_oCol_48"
        Me._oCol_48.ReadOnly = True
        Me._oCol_48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_48.Size = New System.Drawing.Size(17, 25)
        Me._oCol_48.TabIndex = 69
        Me._oCol_48.Text = ""
        '
        '_oCol_47
        '
        Me._oCol_47.AcceptsReturn = True
        Me._oCol_47.AutoSize = False
        Me._oCol_47.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_47.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_47.Enabled = False
        Me._oCol_47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_47.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_47.Location = New System.Drawing.Point(328, 40)
        Me._oCol_47.MaxLength = 0
        Me._oCol_47.Name = "_oCol_47"
        Me._oCol_47.ReadOnly = True
        Me._oCol_47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_47.Size = New System.Drawing.Size(17, 25)
        Me._oCol_47.TabIndex = 68
        Me._oCol_47.Text = ""
        '
        '_oCol_46
        '
        Me._oCol_46.AcceptsReturn = True
        Me._oCol_46.AutoSize = False
        Me._oCol_46.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_46.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_46.Enabled = False
        Me._oCol_46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_46.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_46.Location = New System.Drawing.Point(312, 40)
        Me._oCol_46.MaxLength = 0
        Me._oCol_46.Name = "_oCol_46"
        Me._oCol_46.ReadOnly = True
        Me._oCol_46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_46.Size = New System.Drawing.Size(17, 25)
        Me._oCol_46.TabIndex = 67
        Me._oCol_46.Text = ""
        '
        '_oCol_45
        '
        Me._oCol_45.AcceptsReturn = True
        Me._oCol_45.AutoSize = False
        Me._oCol_45.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_45.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_45.Enabled = False
        Me._oCol_45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_45.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_45.Location = New System.Drawing.Point(296, 40)
        Me._oCol_45.MaxLength = 0
        Me._oCol_45.Name = "_oCol_45"
        Me._oCol_45.ReadOnly = True
        Me._oCol_45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_45.Size = New System.Drawing.Size(17, 25)
        Me._oCol_45.TabIndex = 66
        Me._oCol_45.Text = ""
        '
        '_oCol_44
        '
        Me._oCol_44.AcceptsReturn = True
        Me._oCol_44.AutoSize = False
        Me._oCol_44.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_44.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_44.Enabled = False
        Me._oCol_44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_44.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_44.Location = New System.Drawing.Point(280, 40)
        Me._oCol_44.MaxLength = 0
        Me._oCol_44.Name = "_oCol_44"
        Me._oCol_44.ReadOnly = True
        Me._oCol_44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_44.Size = New System.Drawing.Size(17, 25)
        Me._oCol_44.TabIndex = 65
        Me._oCol_44.Text = ""
        '
        '_oCol_43
        '
        Me._oCol_43.AcceptsReturn = True
        Me._oCol_43.AutoSize = False
        Me._oCol_43.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_43.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_43.Enabled = False
        Me._oCol_43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_43.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_43.Location = New System.Drawing.Point(264, 40)
        Me._oCol_43.MaxLength = 0
        Me._oCol_43.Name = "_oCol_43"
        Me._oCol_43.ReadOnly = True
        Me._oCol_43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_43.Size = New System.Drawing.Size(17, 25)
        Me._oCol_43.TabIndex = 64
        Me._oCol_43.Text = ""
        '
        '_oCol_42
        '
        Me._oCol_42.AcceptsReturn = True
        Me._oCol_42.AutoSize = False
        Me._oCol_42.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_42.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_42.Enabled = False
        Me._oCol_42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_42.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_42.Location = New System.Drawing.Point(248, 40)
        Me._oCol_42.MaxLength = 0
        Me._oCol_42.Name = "_oCol_42"
        Me._oCol_42.ReadOnly = True
        Me._oCol_42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_42.Size = New System.Drawing.Size(17, 25)
        Me._oCol_42.TabIndex = 63
        Me._oCol_42.Text = ""
        '
        '_oCol_41
        '
        Me._oCol_41.AcceptsReturn = True
        Me._oCol_41.AutoSize = False
        Me._oCol_41.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_41.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_41.Enabled = False
        Me._oCol_41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_41.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_41.Location = New System.Drawing.Point(232, 40)
        Me._oCol_41.MaxLength = 0
        Me._oCol_41.Name = "_oCol_41"
        Me._oCol_41.ReadOnly = True
        Me._oCol_41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_41.Size = New System.Drawing.Size(17, 25)
        Me._oCol_41.TabIndex = 62
        Me._oCol_41.Text = ""
        '
        '_oCol_40
        '
        Me._oCol_40.AcceptsReturn = True
        Me._oCol_40.AutoSize = False
        Me._oCol_40.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_40.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_40.Enabled = False
        Me._oCol_40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_40.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_40.Location = New System.Drawing.Point(216, 40)
        Me._oCol_40.MaxLength = 0
        Me._oCol_40.Name = "_oCol_40"
        Me._oCol_40.ReadOnly = True
        Me._oCol_40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_40.Size = New System.Drawing.Size(17, 25)
        Me._oCol_40.TabIndex = 61
        Me._oCol_40.Text = ""
        '
        '_oCol_39
        '
        Me._oCol_39.AcceptsReturn = True
        Me._oCol_39.AutoSize = False
        Me._oCol_39.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_39.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_39.Enabled = False
        Me._oCol_39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_39.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_39.Location = New System.Drawing.Point(200, 40)
        Me._oCol_39.MaxLength = 0
        Me._oCol_39.Name = "_oCol_39"
        Me._oCol_39.ReadOnly = True
        Me._oCol_39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_39.Size = New System.Drawing.Size(17, 25)
        Me._oCol_39.TabIndex = 60
        Me._oCol_39.Text = ""
        '
        '_oCol_38
        '
        Me._oCol_38.AcceptsReturn = True
        Me._oCol_38.AutoSize = False
        Me._oCol_38.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_38.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_38.Enabled = False
        Me._oCol_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_38.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_38.Location = New System.Drawing.Point(184, 40)
        Me._oCol_38.MaxLength = 0
        Me._oCol_38.Name = "_oCol_38"
        Me._oCol_38.ReadOnly = True
        Me._oCol_38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_38.Size = New System.Drawing.Size(17, 25)
        Me._oCol_38.TabIndex = 59
        Me._oCol_38.Text = ""
        '
        '_oCol_37
        '
        Me._oCol_37.AcceptsReturn = True
        Me._oCol_37.AutoSize = False
        Me._oCol_37.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_37.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_37.Enabled = False
        Me._oCol_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_37.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_37.Location = New System.Drawing.Point(168, 40)
        Me._oCol_37.MaxLength = 0
        Me._oCol_37.Name = "_oCol_37"
        Me._oCol_37.ReadOnly = True
        Me._oCol_37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_37.Size = New System.Drawing.Size(17, 25)
        Me._oCol_37.TabIndex = 58
        Me._oCol_37.Text = ""
        '
        '_oCol_36
        '
        Me._oCol_36.AcceptsReturn = True
        Me._oCol_36.AutoSize = False
        Me._oCol_36.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_36.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_36.Enabled = False
        Me._oCol_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_36.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_36.Location = New System.Drawing.Point(152, 40)
        Me._oCol_36.MaxLength = 0
        Me._oCol_36.Name = "_oCol_36"
        Me._oCol_36.ReadOnly = True
        Me._oCol_36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_36.Size = New System.Drawing.Size(17, 25)
        Me._oCol_36.TabIndex = 57
        Me._oCol_36.Text = ""
        '
        '_oCol_35
        '
        Me._oCol_35.AcceptsReturn = True
        Me._oCol_35.AutoSize = False
        Me._oCol_35.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_35.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_35.Enabled = False
        Me._oCol_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_35.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_35.Location = New System.Drawing.Point(136, 40)
        Me._oCol_35.MaxLength = 0
        Me._oCol_35.Name = "_oCol_35"
        Me._oCol_35.ReadOnly = True
        Me._oCol_35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_35.Size = New System.Drawing.Size(17, 25)
        Me._oCol_35.TabIndex = 56
        Me._oCol_35.Text = ""
        '
        '_oCol_34
        '
        Me._oCol_34.AcceptsReturn = True
        Me._oCol_34.AutoSize = False
        Me._oCol_34.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_34.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_34.Enabled = False
        Me._oCol_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_34.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_34.Location = New System.Drawing.Point(120, 40)
        Me._oCol_34.MaxLength = 0
        Me._oCol_34.Name = "_oCol_34"
        Me._oCol_34.ReadOnly = True
        Me._oCol_34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_34.Size = New System.Drawing.Size(17, 25)
        Me._oCol_34.TabIndex = 55
        Me._oCol_34.Text = ""
        '
        '_oCol_33
        '
        Me._oCol_33.AcceptsReturn = True
        Me._oCol_33.AutoSize = False
        Me._oCol_33.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_33.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_33.Enabled = False
        Me._oCol_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_33.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_33.Location = New System.Drawing.Point(104, 40)
        Me._oCol_33.MaxLength = 0
        Me._oCol_33.Name = "_oCol_33"
        Me._oCol_33.ReadOnly = True
        Me._oCol_33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_33.Size = New System.Drawing.Size(17, 25)
        Me._oCol_33.TabIndex = 54
        Me._oCol_33.Text = ""
        '
        '_oCol_32
        '
        Me._oCol_32.AcceptsReturn = True
        Me._oCol_32.AutoSize = False
        Me._oCol_32.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_32.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_32.Enabled = False
        Me._oCol_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_32.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_32.Location = New System.Drawing.Point(88, 40)
        Me._oCol_32.MaxLength = 0
        Me._oCol_32.Name = "_oCol_32"
        Me._oCol_32.ReadOnly = True
        Me._oCol_32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_32.Size = New System.Drawing.Size(17, 25)
        Me._oCol_32.TabIndex = 53
        Me._oCol_32.Text = ""
        '
        '_oCol_31
        '
        Me._oCol_31.AcceptsReturn = True
        Me._oCol_31.AutoSize = False
        Me._oCol_31.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_31.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_31.Enabled = False
        Me._oCol_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_31.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_31.Location = New System.Drawing.Point(72, 40)
        Me._oCol_31.MaxLength = 0
        Me._oCol_31.Name = "_oCol_31"
        Me._oCol_31.ReadOnly = True
        Me._oCol_31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_31.Size = New System.Drawing.Size(17, 25)
        Me._oCol_31.TabIndex = 52
        Me._oCol_31.Text = ""
        '
        '_oCol_30
        '
        Me._oCol_30.AcceptsReturn = True
        Me._oCol_30.AutoSize = False
        Me._oCol_30.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_30.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_30.Enabled = False
        Me._oCol_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_30.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_30.Location = New System.Drawing.Point(56, 40)
        Me._oCol_30.MaxLength = 0
        Me._oCol_30.Name = "_oCol_30"
        Me._oCol_30.ReadOnly = True
        Me._oCol_30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_30.Size = New System.Drawing.Size(17, 25)
        Me._oCol_30.TabIndex = 51
        Me._oCol_30.Text = ""
        '
        '_oCol_29
        '
        Me._oCol_29.AcceptsReturn = True
        Me._oCol_29.AutoSize = False
        Me._oCol_29.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_29.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_29.Enabled = False
        Me._oCol_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_29.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_29.Location = New System.Drawing.Point(40, 40)
        Me._oCol_29.MaxLength = 0
        Me._oCol_29.Name = "_oCol_29"
        Me._oCol_29.ReadOnly = True
        Me._oCol_29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_29.Size = New System.Drawing.Size(17, 25)
        Me._oCol_29.TabIndex = 50
        Me._oCol_29.Text = ""
        '
        '_oCol_28
        '
        Me._oCol_28.AcceptsReturn = True
        Me._oCol_28.AutoSize = False
        Me._oCol_28.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_28.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_28.Enabled = False
        Me._oCol_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_28.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_28.Location = New System.Drawing.Point(24, 40)
        Me._oCol_28.MaxLength = 0
        Me._oCol_28.Name = "_oCol_28"
        Me._oCol_28.ReadOnly = True
        Me._oCol_28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_28.Size = New System.Drawing.Size(17, 25)
        Me._oCol_28.TabIndex = 49
        Me._oCol_28.Text = ""
        '
        '_oCol_27
        '
        Me._oCol_27.AcceptsReturn = True
        Me._oCol_27.AutoSize = False
        Me._oCol_27.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_27.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_27.Enabled = False
        Me._oCol_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_27.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_27.Location = New System.Drawing.Point(8, 40)
        Me._oCol_27.MaxLength = 0
        Me._oCol_27.Name = "_oCol_27"
        Me._oCol_27.ReadOnly = True
        Me._oCol_27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_27.Size = New System.Drawing.Size(17, 25)
        Me._oCol_27.TabIndex = 48
        Me._oCol_27.Text = ""
        '
        '_oCol_26
        '
        Me._oCol_26.AcceptsReturn = True
        Me._oCol_26.AutoSize = False
        Me._oCol_26.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_26.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_26.Enabled = False
        Me._oCol_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_26.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_26.Location = New System.Drawing.Point(424, 16)
        Me._oCol_26.MaxLength = 0
        Me._oCol_26.Name = "_oCol_26"
        Me._oCol_26.ReadOnly = True
        Me._oCol_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_26.Size = New System.Drawing.Size(17, 25)
        Me._oCol_26.TabIndex = 47
        Me._oCol_26.Text = ""
        '
        '_oCol_25
        '
        Me._oCol_25.AcceptsReturn = True
        Me._oCol_25.AutoSize = False
        Me._oCol_25.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_25.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_25.Enabled = False
        Me._oCol_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_25.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_25.Location = New System.Drawing.Point(408, 16)
        Me._oCol_25.MaxLength = 0
        Me._oCol_25.Name = "_oCol_25"
        Me._oCol_25.ReadOnly = True
        Me._oCol_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_25.Size = New System.Drawing.Size(17, 25)
        Me._oCol_25.TabIndex = 46
        Me._oCol_25.Text = ""
        '
        '_oCol_24
        '
        Me._oCol_24.AcceptsReturn = True
        Me._oCol_24.AutoSize = False
        Me._oCol_24.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_24.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_24.Enabled = False
        Me._oCol_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_24.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_24.Location = New System.Drawing.Point(392, 16)
        Me._oCol_24.MaxLength = 0
        Me._oCol_24.Name = "_oCol_24"
        Me._oCol_24.ReadOnly = True
        Me._oCol_24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_24.Size = New System.Drawing.Size(17, 25)
        Me._oCol_24.TabIndex = 45
        Me._oCol_24.Text = ""
        '
        '_oCol_23
        '
        Me._oCol_23.AcceptsReturn = True
        Me._oCol_23.AutoSize = False
        Me._oCol_23.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_23.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_23.Enabled = False
        Me._oCol_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_23.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_23.Location = New System.Drawing.Point(376, 16)
        Me._oCol_23.MaxLength = 0
        Me._oCol_23.Name = "_oCol_23"
        Me._oCol_23.ReadOnly = True
        Me._oCol_23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_23.Size = New System.Drawing.Size(17, 25)
        Me._oCol_23.TabIndex = 44
        Me._oCol_23.Text = ""
        '
        '_oCol_22
        '
        Me._oCol_22.AcceptsReturn = True
        Me._oCol_22.AutoSize = False
        Me._oCol_22.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_22.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_22.Enabled = False
        Me._oCol_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_22.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_22.Location = New System.Drawing.Point(360, 16)
        Me._oCol_22.MaxLength = 0
        Me._oCol_22.Name = "_oCol_22"
        Me._oCol_22.ReadOnly = True
        Me._oCol_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_22.Size = New System.Drawing.Size(17, 25)
        Me._oCol_22.TabIndex = 43
        Me._oCol_22.Text = ""
        '
        '_oCol_21
        '
        Me._oCol_21.AcceptsReturn = True
        Me._oCol_21.AutoSize = False
        Me._oCol_21.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_21.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_21.Enabled = False
        Me._oCol_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_21.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_21.Location = New System.Drawing.Point(344, 16)
        Me._oCol_21.MaxLength = 0
        Me._oCol_21.Name = "_oCol_21"
        Me._oCol_21.ReadOnly = True
        Me._oCol_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_21.Size = New System.Drawing.Size(17, 25)
        Me._oCol_21.TabIndex = 42
        Me._oCol_21.Text = ""
        '
        '_oCol_20
        '
        Me._oCol_20.AcceptsReturn = True
        Me._oCol_20.AutoSize = False
        Me._oCol_20.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_20.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_20.Enabled = False
        Me._oCol_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_20.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_20.Location = New System.Drawing.Point(328, 16)
        Me._oCol_20.MaxLength = 0
        Me._oCol_20.Name = "_oCol_20"
        Me._oCol_20.ReadOnly = True
        Me._oCol_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_20.Size = New System.Drawing.Size(17, 25)
        Me._oCol_20.TabIndex = 41
        Me._oCol_20.Text = ""
        '
        '_oCol_19
        '
        Me._oCol_19.AcceptsReturn = True
        Me._oCol_19.AutoSize = False
        Me._oCol_19.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_19.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_19.Enabled = False
        Me._oCol_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_19.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_19.Location = New System.Drawing.Point(312, 16)
        Me._oCol_19.MaxLength = 0
        Me._oCol_19.Name = "_oCol_19"
        Me._oCol_19.ReadOnly = True
        Me._oCol_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_19.Size = New System.Drawing.Size(17, 25)
        Me._oCol_19.TabIndex = 40
        Me._oCol_19.Text = ""
        '
        '_oCol_18
        '
        Me._oCol_18.AcceptsReturn = True
        Me._oCol_18.AutoSize = False
        Me._oCol_18.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_18.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_18.Enabled = False
        Me._oCol_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_18.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_18.Location = New System.Drawing.Point(296, 16)
        Me._oCol_18.MaxLength = 0
        Me._oCol_18.Name = "_oCol_18"
        Me._oCol_18.ReadOnly = True
        Me._oCol_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_18.Size = New System.Drawing.Size(17, 25)
        Me._oCol_18.TabIndex = 39
        Me._oCol_18.Text = ""
        '
        '_oCol_17
        '
        Me._oCol_17.AcceptsReturn = True
        Me._oCol_17.AutoSize = False
        Me._oCol_17.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_17.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_17.Enabled = False
        Me._oCol_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_17.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_17.Location = New System.Drawing.Point(280, 16)
        Me._oCol_17.MaxLength = 0
        Me._oCol_17.Name = "_oCol_17"
        Me._oCol_17.ReadOnly = True
        Me._oCol_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_17.Size = New System.Drawing.Size(17, 25)
        Me._oCol_17.TabIndex = 38
        Me._oCol_17.Text = ""
        '
        '_oCol_16
        '
        Me._oCol_16.AcceptsReturn = True
        Me._oCol_16.AutoSize = False
        Me._oCol_16.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_16.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_16.Enabled = False
        Me._oCol_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_16.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_16.Location = New System.Drawing.Point(264, 16)
        Me._oCol_16.MaxLength = 0
        Me._oCol_16.Name = "_oCol_16"
        Me._oCol_16.ReadOnly = True
        Me._oCol_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_16.Size = New System.Drawing.Size(17, 25)
        Me._oCol_16.TabIndex = 37
        Me._oCol_16.Text = ""
        '
        '_oCol_15
        '
        Me._oCol_15.AcceptsReturn = True
        Me._oCol_15.AutoSize = False
        Me._oCol_15.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_15.Enabled = False
        Me._oCol_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_15.Location = New System.Drawing.Point(248, 16)
        Me._oCol_15.MaxLength = 0
        Me._oCol_15.Name = "_oCol_15"
        Me._oCol_15.ReadOnly = True
        Me._oCol_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_15.Size = New System.Drawing.Size(17, 25)
        Me._oCol_15.TabIndex = 36
        Me._oCol_15.Text = ""
        '
        '_oCol_14
        '
        Me._oCol_14.AcceptsReturn = True
        Me._oCol_14.AutoSize = False
        Me._oCol_14.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_14.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_14.Enabled = False
        Me._oCol_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_14.Location = New System.Drawing.Point(232, 16)
        Me._oCol_14.MaxLength = 0
        Me._oCol_14.Name = "_oCol_14"
        Me._oCol_14.ReadOnly = True
        Me._oCol_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_14.Size = New System.Drawing.Size(17, 25)
        Me._oCol_14.TabIndex = 35
        Me._oCol_14.Text = ""
        '
        '_oCol_13
        '
        Me._oCol_13.AcceptsReturn = True
        Me._oCol_13.AutoSize = False
        Me._oCol_13.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_13.Enabled = False
        Me._oCol_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_13.Location = New System.Drawing.Point(216, 16)
        Me._oCol_13.MaxLength = 0
        Me._oCol_13.Name = "_oCol_13"
        Me._oCol_13.ReadOnly = True
        Me._oCol_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_13.Size = New System.Drawing.Size(17, 25)
        Me._oCol_13.TabIndex = 34
        Me._oCol_13.Text = ""
        '
        '_oCol_12
        '
        Me._oCol_12.AcceptsReturn = True
        Me._oCol_12.AutoSize = False
        Me._oCol_12.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_12.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_12.Enabled = False
        Me._oCol_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_12.Location = New System.Drawing.Point(200, 16)
        Me._oCol_12.MaxLength = 0
        Me._oCol_12.Name = "_oCol_12"
        Me._oCol_12.ReadOnly = True
        Me._oCol_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_12.Size = New System.Drawing.Size(17, 25)
        Me._oCol_12.TabIndex = 33
        Me._oCol_12.Text = ""
        '
        '_oCol_11
        '
        Me._oCol_11.AcceptsReturn = True
        Me._oCol_11.AutoSize = False
        Me._oCol_11.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_11.Enabled = False
        Me._oCol_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_11.Location = New System.Drawing.Point(184, 16)
        Me._oCol_11.MaxLength = 0
        Me._oCol_11.Name = "_oCol_11"
        Me._oCol_11.ReadOnly = True
        Me._oCol_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_11.Size = New System.Drawing.Size(17, 25)
        Me._oCol_11.TabIndex = 32
        Me._oCol_11.Text = ""
        '
        '_oCol_10
        '
        Me._oCol_10.AcceptsReturn = True
        Me._oCol_10.AutoSize = False
        Me._oCol_10.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_10.Enabled = False
        Me._oCol_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_10.Location = New System.Drawing.Point(168, 16)
        Me._oCol_10.MaxLength = 0
        Me._oCol_10.Name = "_oCol_10"
        Me._oCol_10.ReadOnly = True
        Me._oCol_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_10.Size = New System.Drawing.Size(17, 25)
        Me._oCol_10.TabIndex = 31
        Me._oCol_10.Text = ""
        '
        '_oCol_9
        '
        Me._oCol_9.AcceptsReturn = True
        Me._oCol_9.AutoSize = False
        Me._oCol_9.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_9.Enabled = False
        Me._oCol_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_9.Location = New System.Drawing.Point(152, 16)
        Me._oCol_9.MaxLength = 0
        Me._oCol_9.Name = "_oCol_9"
        Me._oCol_9.ReadOnly = True
        Me._oCol_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_9.Size = New System.Drawing.Size(17, 25)
        Me._oCol_9.TabIndex = 30
        Me._oCol_9.Text = ""
        '
        '_oCol_8
        '
        Me._oCol_8.AcceptsReturn = True
        Me._oCol_8.AutoSize = False
        Me._oCol_8.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_8.Enabled = False
        Me._oCol_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_8.Location = New System.Drawing.Point(136, 16)
        Me._oCol_8.MaxLength = 0
        Me._oCol_8.Name = "_oCol_8"
        Me._oCol_8.ReadOnly = True
        Me._oCol_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_8.Size = New System.Drawing.Size(17, 25)
        Me._oCol_8.TabIndex = 29
        Me._oCol_8.Text = ""
        '
        '_oCol_7
        '
        Me._oCol_7.AcceptsReturn = True
        Me._oCol_7.AutoSize = False
        Me._oCol_7.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_7.Enabled = False
        Me._oCol_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_7.Location = New System.Drawing.Point(120, 16)
        Me._oCol_7.MaxLength = 0
        Me._oCol_7.Name = "_oCol_7"
        Me._oCol_7.ReadOnly = True
        Me._oCol_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_7.Size = New System.Drawing.Size(17, 25)
        Me._oCol_7.TabIndex = 28
        Me._oCol_7.Text = ""
        '
        '_oCol_6
        '
        Me._oCol_6.AcceptsReturn = True
        Me._oCol_6.AutoSize = False
        Me._oCol_6.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_6.Enabled = False
        Me._oCol_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_6.Location = New System.Drawing.Point(104, 16)
        Me._oCol_6.MaxLength = 0
        Me._oCol_6.Name = "_oCol_6"
        Me._oCol_6.ReadOnly = True
        Me._oCol_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_6.Size = New System.Drawing.Size(17, 25)
        Me._oCol_6.TabIndex = 27
        Me._oCol_6.Text = ""
        '
        '_oCol_5
        '
        Me._oCol_5.AcceptsReturn = True
        Me._oCol_5.AutoSize = False
        Me._oCol_5.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_5.Enabled = False
        Me._oCol_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_5.Location = New System.Drawing.Point(88, 16)
        Me._oCol_5.MaxLength = 0
        Me._oCol_5.Name = "_oCol_5"
        Me._oCol_5.ReadOnly = True
        Me._oCol_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_5.Size = New System.Drawing.Size(17, 25)
        Me._oCol_5.TabIndex = 26
        Me._oCol_5.Text = ""
        '
        '_oCol_4
        '
        Me._oCol_4.AcceptsReturn = True
        Me._oCol_4.AutoSize = False
        Me._oCol_4.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_4.Enabled = False
        Me._oCol_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_4.Location = New System.Drawing.Point(72, 16)
        Me._oCol_4.MaxLength = 0
        Me._oCol_4.Name = "_oCol_4"
        Me._oCol_4.ReadOnly = True
        Me._oCol_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_4.Size = New System.Drawing.Size(17, 25)
        Me._oCol_4.TabIndex = 25
        Me._oCol_4.Text = ""
        '
        '_oCol_3
        '
        Me._oCol_3.AcceptsReturn = True
        Me._oCol_3.AutoSize = False
        Me._oCol_3.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_3.Enabled = False
        Me._oCol_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_3.Location = New System.Drawing.Point(56, 16)
        Me._oCol_3.MaxLength = 0
        Me._oCol_3.Name = "_oCol_3"
        Me._oCol_3.ReadOnly = True
        Me._oCol_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_3.Size = New System.Drawing.Size(17, 25)
        Me._oCol_3.TabIndex = 24
        Me._oCol_3.Text = ""
        '
        '_oCol_2
        '
        Me._oCol_2.AcceptsReturn = True
        Me._oCol_2.AutoSize = False
        Me._oCol_2.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_2.Enabled = False
        Me._oCol_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_2.Location = New System.Drawing.Point(40, 16)
        Me._oCol_2.MaxLength = 0
        Me._oCol_2.Name = "_oCol_2"
        Me._oCol_2.ReadOnly = True
        Me._oCol_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_2.Size = New System.Drawing.Size(17, 25)
        Me._oCol_2.TabIndex = 23
        Me._oCol_2.Text = ""
        '
        '_oCol_1
        '
        Me._oCol_1.AcceptsReturn = True
        Me._oCol_1.AutoSize = False
        Me._oCol_1.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_1.Enabled = False
        Me._oCol_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_1.Location = New System.Drawing.Point(24, 16)
        Me._oCol_1.MaxLength = 0
        Me._oCol_1.Name = "_oCol_1"
        Me._oCol_1.ReadOnly = True
        Me._oCol_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_1.Size = New System.Drawing.Size(17, 25)
        Me._oCol_1.TabIndex = 22
        Me._oCol_1.Text = ""
        '
        '_oCol_0
        '
        Me._oCol_0.AcceptsReturn = True
        Me._oCol_0.AutoSize = False
        Me._oCol_0.BackColor = System.Drawing.SystemColors.Info
        Me._oCol_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._oCol_0.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._oCol_0.Enabled = False
        Me._oCol_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._oCol_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._oCol_0.Location = New System.Drawing.Point(8, 16)
        Me._oCol_0.MaxLength = 0
        Me._oCol_0.Name = "_oCol_0"
        Me._oCol_0.ReadOnly = True
        Me._oCol_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._oCol_0.Size = New System.Drawing.Size(17, 25)
        Me._oCol_0.TabIndex = 21
        Me._oCol_0.Text = ""
        '
        'frmCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(464, 277)
        Me.Controls.Add(Me.oColDex)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 418)
        Me.MaximizeBox = False
        Me.Name = "frmCT"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Color Table"
        CType(Me.oCol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oColDex.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Sub SetUpCT(ByVal nFilePath As String)
        Dim f As Short = FreeFile()
        Dim dexArray() As Byte
        Dim nbrCols As Short
        Dim bgrTwo, bgrOne, bgrThree As Integer
        Dim greenVal, blueVal, redVal As Byte
        Dim greenValint, blueValint, redValint As Short
        Dim tfIncre As Short = 0
        Dim MyColor As Object
        Dim tfTarget As String
        Dim ctr As Control

        FileOpen(f, nFilePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
        FileGet(f, nbrCols, 47)
        'nbrCols = ((nbrCols * 4) + 54)

        'UPGRADE_WARNING: Lower bound of array dexArray was changed from 55 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
        'this array needs to be the length of the colortable
        'number of colors times four
        Dim NumberOfBytesInColorTable = nbrCols * 4
        ReDim dexArray(NumberOfBytesInColorTable - 1)
        FileGet(f, dexArray, 55)
        FileClose(f)

        Try
            For tfInt As Short = 0 To NumberOfBytesInColorTable - 1 Step 4
                bgrOne = tfInt
                bgrTwo = (tfInt + 1)
                bgrThree = (tfInt + 2)

                redVal = dexArray(bgrOne)
                greenVal = dexArray(bgrTwo)
                blueVal = dexArray(bgrThree)

                blueValint = CShort(blueVal)
                greenValint = CShort(greenVal)
                redValint = CShort(redVal)

                ctr = FindControl(Me, "_oCol_" & tfIncre)
                SetBackColor(ctr, blueValint, greenValint, redValint) 'white

                tfIncre = tfIncre + 1
            Next tfInt
        Catch ex As Exception
            MsgBox("Problem setting up color table. Error:" & ex.Message)
            Me.Close()
            Me.Dispose()
        End Try
    End Sub

    Private Function FindControl(ByRef Container As Control, ByVal Name As String) As Control
        Return SearchControl(Container, Name)
    End Function

    Private Function SearchControl(ByRef nControl As Control, ByRef nName As String) As Control
        If nControl.Name = nName Then
            Return nControl
        End If
        Dim ctr As Control
        Dim c As Control
        For Each ctr In nControl.Controls
            c = SearchControl(ctr, nName)
            If Not c Is Nothing Then
                Return c
            End If
        Next ctr
    End Function


    Public Sub SetBackColor(ByVal obj As Object, ByVal b As Integer, ByVal g As Integer, ByVal r As Integer)
        Try
            obj.BackColor = Color.FromArgb(255, b, g, r)
            'obj.ToolTipText = b & " " & g & " " & r
            'obj.MousePointer = 2

            If (b = 255) And (g = 255) And (r = 255) Then
                obj.Text = "w"
                'obj.Alignment = 2
            Else
                obj.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Problem setting the back color. Error: " & ex.Message)
        End Try
    End Sub

    Public Sub ClearColorTable()
        For tfInt As Short = 0 To 255
            SetBackColor(oCol(tfInt), 255, 255, 225)
        Next tfInt
    End Sub

End Class