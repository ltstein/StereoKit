---
layout: default
title: Log.Unsubscribe
description: If you subscribed to the log callback, you can unsubscribe that callback here! This method can safely be called before initialization.
---
# [Log]({{site.url}}/Pages/Reference/Log.html).Unsubscribe

<div class='signature' markdown='1'>
static void Unsubscribe(LogCallback onLog)
</div>

|  |  |
|--|--|
|LogCallback onLog|The subscribed callback to remove.|

If you subscribed to the log callback, you can
unsubscribe that callback here!
This method can safely be called before initialization.




## Examples

```csharp
LogCallback onLog = (LogLevel level, string logText) 
	=> Console.WriteLine(logText);

Log.Subscribe(onLog);
```
...
```csharp
Log.Unsubscribe(onLog);
```

