﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChatUC.ascx.cs" Inherits="DO_AN_TN.UserControl.ChatUC" %>
<link href="../App_Themes/layout.css" rel="stylesheet" type="text/css" />
<div>
    <article class="module width_quarter">
	    <header><h3>Messages</h3></header>
	    <div class="message_list">
		    <div class="module_content">
			    <div class="message"><p>Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor.</p>
			    <p><strong>John Doe</strong></p></div>
			    <div class="message"><p>Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor.</p>
			    <p><strong>John Doe</strong></p></div>
			    <div class="message"><p>Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor.</p>
			    <p><strong>John Doe</strong></p></div>
			    <div class="message"><p>Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor.</p>
			    <p><strong>John Doe</strong></p></div>
			    <div class="message"><p>Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor.</p>
			    <p><strong>John Doe</strong></p></div>
		    </div>
	    </div>
	    <footer>
		    <form class="post_message">
			    <input type="text" value="Message" onfocus="if(!this._haschanged){this.value=''};this._haschanged=true;">
			    <input type="submit" class="btn_post_message" value=""/>
		    </form>
	    </footer>
    </article><!-- end of messages article -->
</div>