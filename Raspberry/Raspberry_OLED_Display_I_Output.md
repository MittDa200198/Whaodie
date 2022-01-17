# Ausgabe der IP

```python
import socket

# ip herausfinden

ip = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
ip.connect(("8.8.8.8", 80))

print("HN: ", socket.gethostname())
print("IP: ", ip.getsockname()[0])
```

