# Overview

I haven't had any prior experience with networking before this assignment so I wanted to take spend some time to learn about how I could utilize networking capabilities 
that are available in C# to create a Peer to Peer messaging app with a GUI.

The program that I wrote, I wrote specifically to be run on a single computer, but can, with relative ease, be edited to allow for different systems to connect. Because it is peer
to peer, both ends act as server and client, so we first enter in the IPv4 address, then the port that we want to use, and the port of the person we are connecting to. When the information
is entered, we can click connect and begin sending messages. The users can then type messages in the message box and hit enter or the send button to send the message which then appears
on the message window.

The purpose of this software was to delve into networking and expand my skills in that realm and to see if it is something that I am interested in beyond the simple scope of the program.

[Software Demo Video](https://youtu.be/Uf2zVxS2TJs)

# Network Communication

This program is a peer to peer connection

I am using UDP and defining the ports when the program runs.

The format is plain text using ASCII encoding.

# Development Environment

I used Visual Studio and lots of Google searches

This program is written in C# using the System.Net, and System.Net.Sockets libraries

# Useful Websites
* [microsoft.com](https://learn.microsoft.com/en-us/dotnet/api/system.net.sockets.tcplistener?redirectedfrom=MSDN&view=net-7.0)
* [daveoncsharp.com](https://www.daveoncsharp.com/2009/08/csharp-chat-application-over-asynchronous-udp-sockets-part-1/)

# Future Work
* Cleaner UI
* Change the code so that the program can be used on different systems
* Define the port of the user so that they only need to enter the port and ip of the person to which they want to chat