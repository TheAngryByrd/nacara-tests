---
layout: api
---

<div class="is-size-3">Say</div>

<p>
<div>
<strong>Namespace:</strong>&nbsp;<a href="/documentation/reference/Library2/library2.html">Library2</a></div>
</p>
<p class="is-size-5"><strong>Declared types</strong></p>

<p>
<table class="table is-bordered docs-types">
<thead>
<tr>
<th width="25%">Type</th>
<th width="75%">Description</th>
</tr>
</thead>
<tbody>
<tr>
<td><a href="/documentation/reference/Library2/library2-say-colors.html">Colors</a></td>
<td>

This is colors

</td>
</tr>
</tbody>
</table>
</p>
<p class="is-size-5"><strong>Values and functions</strong></p>

<hr/>
<div class="api-code">
<div><span class="keyword">val</span>&nbsp;<a href="#goodbye" id="goodbye">goodbye</a>&nbsp;<span class="keyword">:</span></div><div>&nbsp;&nbsp;&nbsp;&nbsp;name&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">:</span>&nbsp;string&nbsp;</div>
<div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">-></span>&nbsp;unit</div></div>


This says goodbye to a name

<p><strong>Parameters</strong></p>
<div class="doc-parameter">
<div class="api-code"><span class="property">name</span>&nbsp;<span class="keyword">:</span>&nbsp;string</div>
</div>
<p><strong>Returns</strong></p><p></p>
<hr/>
<div class="api-code">
<div><span class="keyword">val</span>&nbsp;<a href="#send_as_json" id="send_as_json">sendAsJson</a>&nbsp;<span class="keyword">:</span></div><div>&nbsp;&nbsp;&nbsp;&nbsp;o&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">:</span>&nbsp;obj&nbsp;</div>
<div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">-></span>&nbsp;<a href="https://docs.microsoft.com/dotnet/api/newtonsoft.json.linq.jtoken">JToken</a></div></div>


Creates a JToken

<p><strong>Parameters</strong></p>
<div class="doc-parameter">
<div class="api-code"><span class="property">o</span>&nbsp;<span class="keyword">:</span>&nbsp;obj</div>
</div>
<p><strong>Returns</strong></p><p></p>
<hr/>
<div class="api-code">
<div><span class="keyword">val</span>&nbsp;<a href="#add" id="add">add</a>&nbsp;<span class="keyword">:</span></div><div>&nbsp;&nbsp;&nbsp;&nbsp;a&nbsp;&nbsp;&nbsp;<span class="keyword">:</span>&nbsp;int&nbsp;<span class="keyword">-></span></div>
<div>&nbsp;&nbsp;&nbsp;&nbsp;b&nbsp;&nbsp;&nbsp;<span class="keyword">:</span>&nbsp;int&nbsp;</div>
<div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">-></span>&nbsp;int</div></div>


Adds two integers <code>a</code> and <code>b</code> and returns the result. 
Testing langword: <see langword="string"/>.
Testing method reference : <see cref="M:Microsoft.FSharp.Core.Operators.compare"/>.

<p><strong>Parameters</strong></p>
<div class="doc-parameter">
<div class="api-code"><span class="property">a</span>&nbsp;<span class="keyword">:</span>&nbsp;int</div>
An integer.</div>
<div class="doc-parameter">
<div class="api-code"><span class="property">b</span>&nbsp;<span class="keyword">:</span>&nbsp;int</div>
An integer.</div>
<p><strong>Returns</strong></p><p>
The sum of two integers.
</p>
<hr/>
