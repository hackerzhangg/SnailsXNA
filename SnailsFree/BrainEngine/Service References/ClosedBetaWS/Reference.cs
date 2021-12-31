﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwoBrainsGames.BrainEngine.ClosedBetaWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://twobrainsgames.xesf.net/snails/services/closedbeta.wsdl", ConfigurationName="ClosedBetaWS.ClosedBetaPortType")]
    public interface ClosedBetaPortType {
        
        // CODEGEN: Generating message contract since the wrapper namespace (urn:snailsgame:closedbetaservice) of message RegisterUserRequest does not match the default value (http://twobrainsgames.xesf.net/snails/services/closedbeta.wsdl)
        [System.ServiceModel.OperationContractAttribute(Action="registerUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterUserResponse RegisterUser(TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterUserRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (urn:snailsgame:closedbetaservice) of message LoginRequest does not match the default value (http://twobrainsgames.xesf.net/snails/services/closedbeta.wsdl)
        [System.ServiceModel.OperationContractAttribute(Action="login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        TwoBrainsGames.BrainEngine.ClosedBetaWS.LoginResponse Login(TwoBrainsGames.BrainEngine.ClosedBetaWS.LoginRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (urn:snailsgame:closedbetaservice) of message RegisterLogRequest does not match the default value (http://twobrainsgames.xesf.net/snails/services/closedbeta.wsdl)
        [System.ServiceModel.OperationContractAttribute(Action="registerLog", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterLogResponse RegisterLog(TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterLogRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (urn:snailsgame:closedbetaservice) of message RegisterStageStatsRequest does not match the default value (http://twobrainsgames.xesf.net/snails/services/closedbeta.wsdl)
        [System.ServiceModel.OperationContractAttribute(Action="registerStageStats", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterStageStatsResponse RegisterStageStats(TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterStageStatsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterUser", WrapperNamespace="urn:snailsgame:closedbetaservice", IsWrapped=true)]
    public partial class RegisterUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string email;
        
        public RegisterUserRequest() {
        }
        
        public RegisterUserRequest(string email) {
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterUserResponse", WrapperNamespace="urn:snailsgame:closedbetaservice", IsWrapped=true)]
    public partial class RegisterUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int statusCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string statusMsg;
        
        public RegisterUserResponse() {
        }
        
        public RegisterUserResponse(int statusCode, string statusMsg) {
            this.statusCode = statusCode;
            this.statusMsg = statusMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Login", WrapperNamespace="urn:snailsgame:closedbetaservice", IsWrapped=true)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string time;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string macaddress;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string betakey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string country;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=4)]
        public string gameversion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=5)]
        public string os;
        
        public LoginRequest() {
        }
        
        public LoginRequest(string time, string macaddress, string betakey, string country, string gameversion, string os) {
            this.time = time;
            this.macaddress = macaddress;
            this.betakey = betakey;
            this.country = country;
            this.gameversion = gameversion;
            this.os = os;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginResponse", WrapperNamespace="urn:snailsgame:closedbetaservice", IsWrapped=true)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int statusCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string statusMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string SID;
        
        public LoginResponse() {
        }
        
        public LoginResponse(int statusCode, string statusMsg, string SID) {
            this.statusCode = statusCode;
            this.statusMsg = statusMsg;
            this.SID = SID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterLog", WrapperNamespace="urn:snailsgame:closedbetaservice", IsWrapped=true)]
    public partial class RegisterLogRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string SID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string time;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public int severity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string message;
        
        public RegisterLogRequest() {
        }
        
        public RegisterLogRequest(string SID, string time, int severity, string message) {
            this.SID = SID;
            this.time = time;
            this.severity = severity;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterLogResponse", WrapperNamespace="urn:snailsgame:closedbetaservice", IsWrapped=true)]
    public partial class RegisterLogResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int statusCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string statusMsg;
        
        public RegisterLogResponse() {
        }
        
        public RegisterLogResponse(int statusCode, string statusMsg) {
            this.statusCode = statusCode;
            this.statusMsg = statusMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterStageStats", WrapperNamespace="urn:snailsgame:closedbetaservice", IsWrapped=true)]
    public partial class RegisterStageStatsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string SID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string theme;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public int stageNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string startAt;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=4)]
        public int status;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=5)]
        public int goldcoins;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=6)]
        public int silvercoins;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=7)]
        public int bronzecoins;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=8)]
        public int score;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=9)]
        public int unusedtools;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=10)]
        public string time;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=11)]
        public bool highscore;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=12)]
        public int medal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=13)]
        public int stageBuild;
        
        public RegisterStageStatsRequest() {
        }
        
        public RegisterStageStatsRequest(string SID, string theme, int stageNumber, string startAt, int status, int goldcoins, int silvercoins, int bronzecoins, int score, int unusedtools, string time, bool highscore, int medal, int stageBuild) {
            this.SID = SID;
            this.theme = theme;
            this.stageNumber = stageNumber;
            this.startAt = startAt;
            this.status = status;
            this.goldcoins = goldcoins;
            this.silvercoins = silvercoins;
            this.bronzecoins = bronzecoins;
            this.score = score;
            this.unusedtools = unusedtools;
            this.time = time;
            this.highscore = highscore;
            this.medal = medal;
            this.stageBuild = stageBuild;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RegisterStageStatsResponse", WrapperNamespace="urn:snailsgame:closedbetaservice", IsWrapped=true)]
    public partial class RegisterStageStatsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int statusCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string statusMsg;
        
        public RegisterStageStatsResponse() {
        }
        
        public RegisterStageStatsResponse(int statusCode, string statusMsg) {
            this.statusCode = statusCode;
            this.statusMsg = statusMsg;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClosedBetaPortTypeChannel : TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClosedBetaPortTypeClient : System.ServiceModel.ClientBase<TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType>, TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType {
        
        public ClosedBetaPortTypeClient() {
        }
        
        public ClosedBetaPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClosedBetaPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClosedBetaPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClosedBetaPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterUserResponse TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType.RegisterUser(TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterUserRequest request) {
            return base.Channel.RegisterUser(request);
        }
        
        public int RegisterUser(string email, out string statusMsg) {
            TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterUserRequest inValue = new TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterUserRequest();
            inValue.email = email;
            TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterUserResponse retVal = ((TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType)(this)).RegisterUser(inValue);
            statusMsg = retVal.statusMsg;
            return retVal.statusCode;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TwoBrainsGames.BrainEngine.ClosedBetaWS.LoginResponse TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType.Login(TwoBrainsGames.BrainEngine.ClosedBetaWS.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public int Login(string time, string macaddress, string betakey, string country, string gameversion, string os, out string statusMsg, out string SID) {
            TwoBrainsGames.BrainEngine.ClosedBetaWS.LoginRequest inValue = new TwoBrainsGames.BrainEngine.ClosedBetaWS.LoginRequest();
            inValue.time = time;
            inValue.macaddress = macaddress;
            inValue.betakey = betakey;
            inValue.country = country;
            inValue.gameversion = gameversion;
            inValue.os = os;
            TwoBrainsGames.BrainEngine.ClosedBetaWS.LoginResponse retVal = ((TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType)(this)).Login(inValue);
            statusMsg = retVal.statusMsg;
            SID = retVal.SID;
            return retVal.statusCode;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterLogResponse TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType.RegisterLog(TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterLogRequest request) {
            return base.Channel.RegisterLog(request);
        }
        
        public int RegisterLog(string SID, string time, int severity, string message, out string statusMsg) {
            TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterLogRequest inValue = new TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterLogRequest();
            inValue.SID = SID;
            inValue.time = time;
            inValue.severity = severity;
            inValue.message = message;
            TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterLogResponse retVal = ((TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType)(this)).RegisterLog(inValue);
            statusMsg = retVal.statusMsg;
            return retVal.statusCode;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterStageStatsResponse TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType.RegisterStageStats(TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterStageStatsRequest request) {
            return base.Channel.RegisterStageStats(request);
        }
        
        public int RegisterStageStats(string SID, string theme, int stageNumber, string startAt, int status, int goldcoins, int silvercoins, int bronzecoins, int score, int unusedtools, string time, bool highscore, int medal, int stageBuild, out string statusMsg) {
            TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterStageStatsRequest inValue = new TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterStageStatsRequest();
            inValue.SID = SID;
            inValue.theme = theme;
            inValue.stageNumber = stageNumber;
            inValue.startAt = startAt;
            inValue.status = status;
            inValue.goldcoins = goldcoins;
            inValue.silvercoins = silvercoins;
            inValue.bronzecoins = bronzecoins;
            inValue.score = score;
            inValue.unusedtools = unusedtools;
            inValue.time = time;
            inValue.highscore = highscore;
            inValue.medal = medal;
            inValue.stageBuild = stageBuild;
            TwoBrainsGames.BrainEngine.ClosedBetaWS.RegisterStageStatsResponse retVal = ((TwoBrainsGames.BrainEngine.ClosedBetaWS.ClosedBetaPortType)(this)).RegisterStageStats(inValue);
            statusMsg = retVal.statusMsg;
            return retVal.statusCode;
        }
    }
}
