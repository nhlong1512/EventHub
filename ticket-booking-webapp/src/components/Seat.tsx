import classNames from 'classnames';
import React from 'react'

interface Props {
    typeSeat: string,
    statusSeat: string
}

const Seat = ({typeSeat, statusSeat}: Props) => {
  return (
    <div className='w-[40px] h-[40px] border-main border-[2px] border-solid rouned-[2px] flex justify-center items-center cursor-pointer hover:opacity-80'>
        <p className='m-0'>10</p>
    </div>
  )
}

export default Seat