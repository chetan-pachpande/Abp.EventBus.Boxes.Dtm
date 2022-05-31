using System.Collections.Generic;
using Volo.Abp.EventBus.Distributed;

namespace EasyAbp.Abp.EventBus.Boxes.Dtm;

public interface IEventInfosSerializer
{
    string Serialize(List<OutgoingEventInfo> eventInfos);

    List<OutgoingEventInfo> Deserialize(string byteString);
}
