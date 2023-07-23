export interface ISeat {
    seatId: number;
    typeSeat: 'vip' | 'standard' | 'sweet-box';
    statusSeat: 'default' | 'picked' | 'picking' | 'banned';
}