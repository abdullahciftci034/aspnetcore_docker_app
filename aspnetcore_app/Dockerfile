FROM ubuntu:20.04
RUN apt update
RUN apt install -y wget 
RUN wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN apt update
RUN apt install -yq mono-complete 
RUN apt install -yq aspnetcore-runtime-7.0 
RUN apt install -yq dotnet-sdk-7.0
WORKDIR /aspnetcore_app
CMD [ "dotnet","watch","run"]